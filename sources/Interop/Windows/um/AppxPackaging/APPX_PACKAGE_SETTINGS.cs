// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct APPX_PACKAGE_SETTINGS
    {
        [NativeTypeName("BOOL")]
        public int forceZip32;

        public IUri* hashMethod;
    }
}
