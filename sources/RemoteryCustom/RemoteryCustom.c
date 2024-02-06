#include "RemoteryCustom.h"

RMT_API rmtBool rmtnet_useCUDA() { return RMT_USE_CUDA; }
RMT_API rmtBool rmtnet_useD3D11() { return RMT_USE_D3D11; }
RMT_API rmtBool rmtnet_useOpenGL() { return RMT_USE_OPENGL; }
RMT_API rmtBool rmtnet_useMetal() { return RMT_USE_METAL; }
RMT_API rmtBool rmtnet_useVulkan() { return RMT_USE_VULKAN; }
