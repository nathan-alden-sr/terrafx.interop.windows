// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodecsdk.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("9204FE99-D8FC-4FD5-A001-9536B067A899")]
    [NativeTypeName("struct IWICMetadataReader : IUnknown")]
    public unsafe partial struct IWICMetadataReader
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IWICMetadataReader*, Guid*, void**, int>)(lpVtbl[0]))((IWICMetadataReader*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IWICMetadataReader*, uint>)(lpVtbl[1]))((IWICMetadataReader*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IWICMetadataReader*, uint>)(lpVtbl[2]))((IWICMetadataReader*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetMetadataFormat([NativeTypeName("GUID *")] Guid* pguidMetadataFormat)
        {
            return ((delegate* unmanaged<IWICMetadataReader*, Guid*, int>)(lpVtbl[3]))((IWICMetadataReader*)Unsafe.AsPointer(ref this), pguidMetadataFormat);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetMetadataHandlerInfo(IWICMetadataHandlerInfo** ppIHandler)
        {
            return ((delegate* unmanaged<IWICMetadataReader*, IWICMetadataHandlerInfo**, int>)(lpVtbl[4]))((IWICMetadataReader*)Unsafe.AsPointer(ref this), ppIHandler);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCount([NativeTypeName("UINT *")] uint* pcCount)
        {
            return ((delegate* unmanaged<IWICMetadataReader*, uint*, int>)(lpVtbl[5]))((IWICMetadataReader*)Unsafe.AsPointer(ref this), pcCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetValueByIndex([NativeTypeName("UINT")] uint nIndex, PROPVARIANT* pvarSchema, PROPVARIANT* pvarId, PROPVARIANT* pvarValue)
        {
            return ((delegate* unmanaged<IWICMetadataReader*, uint, PROPVARIANT*, PROPVARIANT*, PROPVARIANT*, int>)(lpVtbl[6]))((IWICMetadataReader*)Unsafe.AsPointer(ref this), nIndex, pvarSchema, pvarId, pvarValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetValue([NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarSchema, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarId, PROPVARIANT* pvarValue)
        {
            return ((delegate* unmanaged<IWICMetadataReader*, PROPVARIANT*, PROPVARIANT*, PROPVARIANT*, int>)(lpVtbl[7]))((IWICMetadataReader*)Unsafe.AsPointer(ref this), pvarSchema, pvarId, pvarValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetEnumerator(IWICEnumMetadataItem** ppIEnumMetadata)
        {
            return ((delegate* unmanaged<IWICMetadataReader*, IWICEnumMetadataItem**, int>)(lpVtbl[8]))((IWICMetadataReader*)Unsafe.AsPointer(ref this), ppIEnumMetadata);
        }
    }
}
