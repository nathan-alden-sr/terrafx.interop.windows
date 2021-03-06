// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_1.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("689F1F85-C72E-4E33-8F19-85754EFD5ACE")]
    [NativeTypeName("struct ID2D1DrawingStateBlock1 : ID2D1DrawingStateBlock")]
    public unsafe partial struct ID2D1DrawingStateBlock1
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID2D1DrawingStateBlock1*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1DrawingStateBlock1*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID2D1DrawingStateBlock1*, uint>)(lpVtbl[1]))((ID2D1DrawingStateBlock1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID2D1DrawingStateBlock1*, uint>)(lpVtbl[2]))((ID2D1DrawingStateBlock1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetFactory(ID2D1Factory** factory)
        {
            ((delegate* unmanaged<ID2D1DrawingStateBlock1*, ID2D1Factory**, void>)(lpVtbl[3]))((ID2D1DrawingStateBlock1*)Unsafe.AsPointer(ref this), factory);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetDescription(D2D1_DRAWING_STATE_DESCRIPTION* stateDescription)
        {
            ((delegate* unmanaged<ID2D1DrawingStateBlock1*, D2D1_DRAWING_STATE_DESCRIPTION*, void>)(lpVtbl[4]))((ID2D1DrawingStateBlock1*)Unsafe.AsPointer(ref this), stateDescription);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetDescription([NativeTypeName("const D2D1_DRAWING_STATE_DESCRIPTION *")] D2D1_DRAWING_STATE_DESCRIPTION* stateDescription)
        {
            ((delegate* unmanaged<ID2D1DrawingStateBlock1*, D2D1_DRAWING_STATE_DESCRIPTION*, void>)(lpVtbl[5]))((ID2D1DrawingStateBlock1*)Unsafe.AsPointer(ref this), stateDescription);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetTextRenderingParams(IDWriteRenderingParams* textRenderingParams = null)
        {
            ((delegate* unmanaged<ID2D1DrawingStateBlock1*, IDWriteRenderingParams*, void>)(lpVtbl[6]))((ID2D1DrawingStateBlock1*)Unsafe.AsPointer(ref this), textRenderingParams);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetTextRenderingParams(IDWriteRenderingParams** textRenderingParams)
        {
            ((delegate* unmanaged<ID2D1DrawingStateBlock1*, IDWriteRenderingParams**, void>)(lpVtbl[7]))((ID2D1DrawingStateBlock1*)Unsafe.AsPointer(ref this), textRenderingParams);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetDescription(D2D1_DRAWING_STATE_DESCRIPTION1* stateDescription)
        {
            ((delegate* unmanaged<ID2D1DrawingStateBlock1*, D2D1_DRAWING_STATE_DESCRIPTION1*, void>)(lpVtbl[8]))((ID2D1DrawingStateBlock1*)Unsafe.AsPointer(ref this), stateDescription);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetDescription([NativeTypeName("const D2D1_DRAWING_STATE_DESCRIPTION1 *")] D2D1_DRAWING_STATE_DESCRIPTION1* stateDescription)
        {
            ((delegate* unmanaged<ID2D1DrawingStateBlock1*, D2D1_DRAWING_STATE_DESCRIPTION1*, void>)(lpVtbl[9]))((ID2D1DrawingStateBlock1*)Unsafe.AsPointer(ref this), stateDescription);
        }
    }
}
