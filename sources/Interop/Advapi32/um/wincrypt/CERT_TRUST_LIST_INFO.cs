// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct CERT_TRUST_LIST_INFO
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        [NativeTypeName("PCTL_ENTRY")]
        public CTL_ENTRY* pCtlEntry;

        [NativeTypeName("PCCTL_CONTEXT")]
        public CTL_CONTEXT* pCtlContext;
    }
}
