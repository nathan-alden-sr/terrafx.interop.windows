// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imapi2fs.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B507CA29-2204-11DD-966A-001AA01BBC58")]
    [NativeTypeName("struct IFileSystemImageResult2 : IFileSystemImageResult")]
    public unsafe partial struct IFileSystemImageResult2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IFileSystemImageResult2*, Guid*, void**, int>)(lpVtbl[0]))((IFileSystemImageResult2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IFileSystemImageResult2*, uint>)(lpVtbl[1]))((IFileSystemImageResult2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IFileSystemImageResult2*, uint>)(lpVtbl[2]))((IFileSystemImageResult2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IFileSystemImageResult2*, uint*, int>)(lpVtbl[3]))((IFileSystemImageResult2*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IFileSystemImageResult2*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IFileSystemImageResult2*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IFileSystemImageResult2*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IFileSystemImageResult2*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IFileSystemImageResult2*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IFileSystemImageResult2*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_ImageStream(IStream** pVal)
        {
            return ((delegate* unmanaged<IFileSystemImageResult2*, IStream**, int>)(lpVtbl[7]))((IFileSystemImageResult2*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_ProgressItems(IProgressItems** pVal)
        {
            return ((delegate* unmanaged<IFileSystemImageResult2*, IProgressItems**, int>)(lpVtbl[8]))((IFileSystemImageResult2*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_TotalBlocks([NativeTypeName("LONG *")] int* pVal)
        {
            return ((delegate* unmanaged<IFileSystemImageResult2*, int*, int>)(lpVtbl[9]))((IFileSystemImageResult2*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_BlockSize([NativeTypeName("LONG *")] int* pVal)
        {
            return ((delegate* unmanaged<IFileSystemImageResult2*, int*, int>)(lpVtbl[10]))((IFileSystemImageResult2*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_DiscId([NativeTypeName("BSTR *")] ushort** pVal)
        {
            return ((delegate* unmanaged<IFileSystemImageResult2*, ushort**, int>)(lpVtbl[11]))((IFileSystemImageResult2*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_ModifiedBlocks(IBlockRangeList** pVal)
        {
            return ((delegate* unmanaged<IFileSystemImageResult2*, IBlockRangeList**, int>)(lpVtbl[12]))((IFileSystemImageResult2*)Unsafe.AsPointer(ref this), pVal);
        }
    }
}
