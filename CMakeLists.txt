cmake_minimum_required(VERSION 3.16)
if (NOT "${CMAKE_TOOLCHAIN_FILE}" STREQUAL "")
    set(VCPKG_CHAINLOAD_TOOLCHAIN_FILE "${CMAKE_TOOLCHAIN_FILE}")
endif()
if ("$ENV{VCPKG_INSTALLATION_ROOT}" STREQUAL "")
    message(FATAL_ERROR "VCPKG_INSTALLATION_ROOT is not set")
    return()
endif()
set(CMAKE_TOOLCHAIN_FILE "$ENV{VCPKG_INSTALLATION_ROOT}/scripts/buildsystems/vcpkg.cmake")

project(remotery)

# By default, we build in Release mode.
if(NOT CMAKE_BUILD_TYPE)
    set(
        CMAKE_BUILD_TYPE "Release" CACHE
        STRING "Choose the type of build." FORCE
    )
endif()

# Build options
# =============

option(REMOTERY_BUILD_SHARED_LIBS "Build remotery shared library" OFF)
option(REMOTERY_BUILD_STATIC_LIBS "Build remotery static library" OFF)

message(STATUS "Build shared libraries: ${REMOTERY_BUILD_SHARED_LIBS}")
message(STATUS "Build static libraries: ${REMOTERY_BUILD_STATIC_LIBS}")

# Targets and link
# ================

include(CheckCXXCompilerFlag)

macro(remotery_create_target target_name linkage output_name)
    string(TOUPPER "${linkage}" linkage_upper)

    if(NOT ${linkage_upper} MATCHES "^(STATIC|SHARED)$")
        message(FATAL_ERROR "Invalid linkage: ${linkage}")
    endif()

    add_library(
        ${target_name} ${linkage_upper}
        Remotery/lib/Remotery.c
        Remotery/lib/Remotery.h
    )

    target_include_directories(
        ${target_name}
        PUBLIC
        $<BUILD_INTERFACE:${CMAKE_CURRENT_SOURCE_DIR}/Remotery/lib>
        $<INSTALL_INTERFACE:include>
    )

    set_target_properties(
        ${target_name}
        PROPERTIES
        OUTPUT_NAME ${output_name}
        PUBLIC_HEADER "Remotery/lib/Remotery.h"
    )

    # Compilation and linkage flags
    # =============================

    if(MSVC)
        target_compile_options(
            ${target_name} PUBLIC /W4
            # NOTE(jjerphan): treating warnings as error makes the installation fail.
            # TODO: remove "/W4"-emitted warnings and use "/WX"
            # /WX
        )
    else()
        target_compile_options(
            ${target_name} PUBLIC -pthread -Wall -Wextra -Wno-unused-parameter -Wno-unused-function -Wno-unused-variable -Wno-unused-but-set-variable
        )
    endif()

    if(${linkage_upper} STREQUAL "STATIC")
        target_compile_definitions(${target_name} PUBLIC RMT_STATIC_LIB)
    endif()

    if (MSVC)
        target_compile_definitions(${target_name} PUBLIC RMT_USE_D3D12=1 RMT_USE_D3D11=1)
        target_link_libraries(${target_name} PRIVATE "dxguid.lib")
    elseif (APPLE)
        # target_compile_definitions(${target_name} PUBLIC RMT_USE_METAL=1)
    endif()

    find_package(VulkanHeaders CONFIG REQUIRED)
    target_link_libraries(${target_name} PRIVATE Vulkan::Headers)
    target_compile_definitions(${target_name} PUBLIC RMT_USE_OPENGL=1 RMT_USE_VULKAN=1)

endmacro()

set(remotery_targets "")

if(REMOTERY_BUILD_SHARED_LIBS)
    remotery_create_target(remotery SHARED remotery)
    list(APPEND remotery_targets remotery)
endif()

if(REMOTERY_BUILD_STATIC_LIBS)
    # On Windows, a static library should use a different output name
    # to avoid name conflicts with the shared library.
    if(WIN32)
        remotery_create_target(remotery-static STATIC remotery_static)
    else()
        remotery_create_target(remotery-static STATIC remotery)
    endif()

    list(APPEND remotery_targets remotery-static)
endif()

# Tests
# =====

# TODO: implement a test suite.
