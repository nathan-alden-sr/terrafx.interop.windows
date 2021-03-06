// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("8ED8981B-7C10-4D7D-9FB3-AB72E9C75F72")]
    [NativeTypeName("struct IEnumTfPropertyValue : IUnknown")]
    public unsafe partial struct IEnumTfPropertyValue
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IEnumTfPropertyValue*, Guid*, void**, int>)(lpVtbl[0]))((IEnumTfPropertyValue*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IEnumTfPropertyValue*, uint>)(lpVtbl[1]))((IEnumTfPropertyValue*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IEnumTfPropertyValue*, uint>)(lpVtbl[2]))((IEnumTfPropertyValue*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Clone(IEnumTfPropertyValue** ppEnum)
        {
            return ((delegate* unmanaged<IEnumTfPropertyValue*, IEnumTfPropertyValue**, int>)(lpVtbl[3]))((IEnumTfPropertyValue*)Unsafe.AsPointer(ref this), ppEnum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Next([NativeTypeName("ULONG")] uint ulCount, TF_PROPERTYVAL* rgValues, [NativeTypeName("ULONG *")] uint* pcFetched)
        {
            return ((delegate* unmanaged<IEnumTfPropertyValue*, uint, TF_PROPERTYVAL*, uint*, int>)(lpVtbl[4]))((IEnumTfPropertyValue*)Unsafe.AsPointer(ref this), ulCount, rgValues, pcFetched);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Reset()
        {
            return ((delegate* unmanaged<IEnumTfPropertyValue*, int>)(lpVtbl[5]))((IEnumTfPropertyValue*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Skip([NativeTypeName("ULONG")] uint ulCount)
        {
            return ((delegate* unmanaged<IEnumTfPropertyValue*, uint, int>)(lpVtbl[6]))((IEnumTfPropertyValue*)Unsafe.AsPointer(ref this), ulCount);
        }
    }
}
