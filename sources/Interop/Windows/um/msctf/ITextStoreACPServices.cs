// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("AA80E901-2021-11D2-93E0-0060B067B86E")]
    [NativeTypeName("struct ITextStoreACPServices : IUnknown")]
    public unsafe partial struct ITextStoreACPServices
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITextStoreACPServices*, Guid*, void**, int>)(lpVtbl[0]))((ITextStoreACPServices*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITextStoreACPServices*, uint>)(lpVtbl[1]))((ITextStoreACPServices*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITextStoreACPServices*, uint>)(lpVtbl[2]))((ITextStoreACPServices*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Serialize(ITfProperty* pProp, ITfRange* pRange, TF_PERSISTENT_PROPERTY_HEADER_ACP* pHdr, IStream* pStream)
        {
            return ((delegate* unmanaged<ITextStoreACPServices*, ITfProperty*, ITfRange*, TF_PERSISTENT_PROPERTY_HEADER_ACP*, IStream*, int>)(lpVtbl[3]))((ITextStoreACPServices*)Unsafe.AsPointer(ref this), pProp, pRange, pHdr, pStream);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Unserialize(ITfProperty* pProp, [NativeTypeName("const TF_PERSISTENT_PROPERTY_HEADER_ACP *")] TF_PERSISTENT_PROPERTY_HEADER_ACP* pHdr, IStream* pStream, ITfPersistentPropertyLoaderACP* pLoader)
        {
            return ((delegate* unmanaged<ITextStoreACPServices*, ITfProperty*, TF_PERSISTENT_PROPERTY_HEADER_ACP*, IStream*, ITfPersistentPropertyLoaderACP*, int>)(lpVtbl[4]))((ITextStoreACPServices*)Unsafe.AsPointer(ref this), pProp, pHdr, pStream, pLoader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ForceLoadProperty(ITfProperty* pProp)
        {
            return ((delegate* unmanaged<ITextStoreACPServices*, ITfProperty*, int>)(lpVtbl[5]))((ITextStoreACPServices*)Unsafe.AsPointer(ref this), pProp);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateRange([NativeTypeName("LONG")] int acpStart, [NativeTypeName("LONG")] int acpEnd, ITfRangeACP** ppRange)
        {
            return ((delegate* unmanaged<ITextStoreACPServices*, int, int, ITfRangeACP**, int>)(lpVtbl[6]))((ITextStoreACPServices*)Unsafe.AsPointer(ref this), acpStart, acpEnd, ppRange);
        }
    }
}
