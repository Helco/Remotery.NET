#!/bin/bash
# dotnet tool update --global ClangSharpPInvokeGenerator --version 17.0.0

ClangSharpPInvokeGenerator \
    --file-directory Remotery/lib \
    --include-directory Remotery/lib \
    "@scripts/GenerateRemotery.rsp"
