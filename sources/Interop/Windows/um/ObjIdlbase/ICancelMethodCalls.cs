// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdlbase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000029-0000-0000-C000-000000000046")]
    [NativeTypeName("struct ICancelMethodCalls : IUnknown")]
    public unsafe partial struct ICancelMethodCalls
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ICancelMethodCalls*, Guid*, void**, int>)(lpVtbl[0]))((ICancelMethodCalls*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ICancelMethodCalls*, uint>)(lpVtbl[1]))((ICancelMethodCalls*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ICancelMethodCalls*, uint>)(lpVtbl[2]))((ICancelMethodCalls*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Cancel([NativeTypeName("ULONG")] uint ulSeconds)
        {
            return ((delegate* unmanaged<ICancelMethodCalls*, uint, int>)(lpVtbl[3]))((ICancelMethodCalls*)Unsafe.AsPointer(ref this), ulSeconds);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int TestCancel()
        {
            return ((delegate* unmanaged<ICancelMethodCalls*, int>)(lpVtbl[4]))((ICancelMethodCalls*)Unsafe.AsPointer(ref this));
        }
    }
}
