// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct WS_SECURITY_DESCRIPTION
    {
        public WS_SECURITY_BINDING** securityBindings;

        [NativeTypeName("ULONG")]
        public uint securityBindingCount;

        public WS_SECURITY_PROPERTY* properties;

        [NativeTypeName("ULONG")]
        public uint propertyCount;
    }
}
