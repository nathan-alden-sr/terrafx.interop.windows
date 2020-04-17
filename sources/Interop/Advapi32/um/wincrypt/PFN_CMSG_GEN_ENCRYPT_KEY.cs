// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    [return: NativeTypeName("BOOL")]
    public unsafe delegate int PFN_CMSG_GEN_ENCRYPT_KEY([NativeTypeName("HCRYPTPROV *")] uint* phCryptProv, [NativeTypeName("PCRYPT_ALGORITHM_IDENTIFIER")] CRYPT_ALGORITHM_IDENTIFIER* paiEncrypt, [NativeTypeName("PVOID")] void* pvEncryptAuxInfo, [NativeTypeName("PCERT_PUBLIC_KEY_INFO")] CERT_PUBLIC_KEY_INFO* pPublicKeyInfo, [NativeTypeName("PFN_CMSG_ALLOC")] IntPtr* pfnAlloc, [NativeTypeName("HCRYPTKEY *")] uint* phEncryptKey, [NativeTypeName("PBYTE *")] byte** ppbEncryptParameters, [NativeTypeName("PDWORD")] uint* pcbEncryptParameters);
}
