// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from https://docs.microsoft.com/en-us/windows/win32/appxpkg/how-to-programmatically-sign-a-package
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

namespace TerraFX.Interop
{
    public unsafe partial struct SIGNER_CERT_STORE_INFO
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        [NativeTypeName("PCCERT_CONTEXT")]
        public CERT_CONTEXT* pSigningCert;

        [NativeTypeName("DWORD")]
        public uint dwCertPolicy;

        [NativeTypeName("HCERTSTORE")]
        public void* hCertStore;
    }
}
