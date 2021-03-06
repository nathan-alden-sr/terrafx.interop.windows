// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ctffunc.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("BB95808A-6D8F-4BCA-8400-5390B586AEDF")]
    [NativeTypeName("struct ITfFnConfigureRegisterWord : ITfFunction")]
    public unsafe partial struct ITfFnConfigureRegisterWord
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITfFnConfigureRegisterWord*, Guid*, void**, int>)(lpVtbl[0]))((ITfFnConfigureRegisterWord*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfFnConfigureRegisterWord*, uint>)(lpVtbl[1]))((ITfFnConfigureRegisterWord*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfFnConfigureRegisterWord*, uint>)(lpVtbl[2]))((ITfFnConfigureRegisterWord*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDisplayName([NativeTypeName("BSTR *")] ushort** pbstrName)
        {
            return ((delegate* unmanaged<ITfFnConfigureRegisterWord*, ushort**, int>)(lpVtbl[3]))((ITfFnConfigureRegisterWord*)Unsafe.AsPointer(ref this), pbstrName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Show([NativeTypeName("HWND")] IntPtr hwndParent, [NativeTypeName("LANGID")] ushort langid, [NativeTypeName("const GUID &")] Guid* rguidProfile, [NativeTypeName("BSTR")] ushort* bstrRegistered)
        {
            return ((delegate* unmanaged<ITfFnConfigureRegisterWord*, IntPtr, ushort, Guid*, ushort*, int>)(lpVtbl[4]))((ITfFnConfigureRegisterWord*)Unsafe.AsPointer(ref this), hwndParent, langid, rguidProfile, bstrRegistered);
        }
    }
}
