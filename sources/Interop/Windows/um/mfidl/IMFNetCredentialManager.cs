// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("5B87EF6B-7ED8-434F-BA0E-184FAC1628D1")]
    [NativeTypeName("struct IMFNetCredentialManager : IUnknown")]
    public unsafe partial struct IMFNetCredentialManager
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFNetCredentialManager*, Guid*, void**, int>)(lpVtbl[0]))((IMFNetCredentialManager*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFNetCredentialManager*, uint>)(lpVtbl[1]))((IMFNetCredentialManager*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFNetCredentialManager*, uint>)(lpVtbl[2]))((IMFNetCredentialManager*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int BeginGetCredentials(MFNetCredentialManagerGetParam* pParam, IMFAsyncCallback* pCallback, IUnknown* pState)
        {
            return ((delegate* unmanaged<IMFNetCredentialManager*, MFNetCredentialManagerGetParam*, IMFAsyncCallback*, IUnknown*, int>)(lpVtbl[3]))((IMFNetCredentialManager*)Unsafe.AsPointer(ref this), pParam, pCallback, pState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EndGetCredentials(IMFAsyncResult* pResult, IMFNetCredential** ppCred)
        {
            return ((delegate* unmanaged<IMFNetCredentialManager*, IMFAsyncResult*, IMFNetCredential**, int>)(lpVtbl[4]))((IMFNetCredentialManager*)Unsafe.AsPointer(ref this), pResult, ppCred);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetGood(IMFNetCredential* pCred, [NativeTypeName("BOOL")] int fGood)
        {
            return ((delegate* unmanaged<IMFNetCredentialManager*, IMFNetCredential*, int, int>)(lpVtbl[5]))((IMFNetCredentialManager*)Unsafe.AsPointer(ref this), pCred, fGood);
        }
    }
}
