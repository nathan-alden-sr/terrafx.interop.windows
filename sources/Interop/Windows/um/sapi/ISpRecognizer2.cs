// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("8FC6D974-C81E-4098-93C5-0147F61ED4D3")]
    [NativeTypeName("struct ISpRecognizer2 : IUnknown")]
    public unsafe partial struct ISpRecognizer2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISpRecognizer2*, Guid*, void**, int>)(lpVtbl[0]))((ISpRecognizer2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISpRecognizer2*, uint>)(lpVtbl[1]))((ISpRecognizer2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISpRecognizer2*, uint>)(lpVtbl[2]))((ISpRecognizer2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EmulateRecognitionEx(ISpPhrase* pPhrase, [NativeTypeName("DWORD")] uint dwCompareFlags)
        {
            return ((delegate* unmanaged<ISpRecognizer2*, ISpPhrase*, uint, int>)(lpVtbl[3]))((ISpRecognizer2*)Unsafe.AsPointer(ref this), pPhrase, dwCompareFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetTrainingState([NativeTypeName("BOOL")] int fDoingTraining, [NativeTypeName("BOOL")] int fAdaptFromTrainingData)
        {
            return ((delegate* unmanaged<ISpRecognizer2*, int, int, int>)(lpVtbl[4]))((ISpRecognizer2*)Unsafe.AsPointer(ref this), fDoingTraining, fAdaptFromTrainingData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ResetAcousticModelAdaptation()
        {
            return ((delegate* unmanaged<ISpRecognizer2*, int>)(lpVtbl[5]))((ISpRecognizer2*)Unsafe.AsPointer(ref this));
        }
    }
}
