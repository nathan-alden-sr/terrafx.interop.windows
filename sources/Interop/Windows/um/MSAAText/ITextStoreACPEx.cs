// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MSAAText.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A2DE3BC2-3D8E-11D3-81A9-F753FBE61A00")]
    [NativeTypeName("struct ITextStoreACPEx : IUnknown")]
    public unsafe partial struct ITextStoreACPEx
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITextStoreACPEx*, Guid*, void**, int>)(lpVtbl[0]))((ITextStoreACPEx*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITextStoreACPEx*, uint>)(lpVtbl[1]))((ITextStoreACPEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITextStoreACPEx*, uint>)(lpVtbl[2]))((ITextStoreACPEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ScrollToRect([NativeTypeName("LONG")] int acpStart, [NativeTypeName("LONG")] int acpEnd, RECT rc, [NativeTypeName("DWORD")] uint dwPosition)
        {
            return ((delegate* unmanaged<ITextStoreACPEx*, int, int, RECT, uint, int>)(lpVtbl[3]))((ITextStoreACPEx*)Unsafe.AsPointer(ref this), acpStart, acpEnd, rc, dwPosition);
        }
    }
}
