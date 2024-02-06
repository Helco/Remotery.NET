#ifndef REMOTERY_CUSTOM_H
#define REMOTERY_CUSTOM_H

#include "../../Remotery/lib/Remotery.h"

RMT_API rmtBool rmtnet_useCUDA();
RMT_API rmtBool rmtnet_useD3D11();
RMT_API rmtBool rmtnet_useOpenGL();
RMT_API rmtBool rmtnet_useMetal();
RMT_API rmtBool rmtnet_useVulkan();

#endif // REMOTERY_CUSTOM_H
