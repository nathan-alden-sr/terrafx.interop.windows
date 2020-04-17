// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct CERT_LOGOTYPE_DATA
    {
        [NativeTypeName("DWORD")]
        public uint cLogotypeImage;

        [NativeTypeName("PCERT_LOGOTYPE_IMAGE")]
        public CERT_LOGOTYPE_IMAGE* rgLogotypeImage;

        [NativeTypeName("DWORD")]
        public uint cLogotypeAudio;

        [NativeTypeName("PCERT_LOGOTYPE_AUDIO")]
        public CERT_LOGOTYPE_AUDIO* rgLogotypeAudio;
    }
}
