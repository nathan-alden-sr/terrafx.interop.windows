// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/InputScope.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("5731EAA0-6BC2-4681-A532-92FBB74D7C41")]
    [NativeTypeName("struct ITfInputScope2 : ITfInputScope")]
    public unsafe partial struct ITfInputScope2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITfInputScope2*, Guid*, void**, int>)(lpVtbl[0]))((ITfInputScope2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfInputScope2*, uint>)(lpVtbl[1]))((ITfInputScope2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfInputScope2*, uint>)(lpVtbl[2]))((ITfInputScope2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetInputScopes(InputScope** pprgInputScopes, [NativeTypeName("UINT *")] uint* pcCount)
        {
            return ((delegate* unmanaged<ITfInputScope2*, InputScope**, uint*, int>)(lpVtbl[3]))((ITfInputScope2*)Unsafe.AsPointer(ref this), pprgInputScopes, pcCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPhrase([NativeTypeName("BSTR **")] ushort*** ppbstrPhrases, [NativeTypeName("UINT *")] uint* pcCount)
        {
            return ((delegate* unmanaged<ITfInputScope2*, ushort***, uint*, int>)(lpVtbl[4]))((ITfInputScope2*)Unsafe.AsPointer(ref this), ppbstrPhrases, pcCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRegularExpression([NativeTypeName("BSTR *")] ushort** pbstrRegExp)
        {
            return ((delegate* unmanaged<ITfInputScope2*, ushort**, int>)(lpVtbl[5]))((ITfInputScope2*)Unsafe.AsPointer(ref this), pbstrRegExp);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSRGS([NativeTypeName("BSTR *")] ushort** pbstrSRGS)
        {
            return ((delegate* unmanaged<ITfInputScope2*, ushort**, int>)(lpVtbl[6]))((ITfInputScope2*)Unsafe.AsPointer(ref this), pbstrSRGS);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetXML([NativeTypeName("BSTR *")] ushort** pbstrXML)
        {
            return ((delegate* unmanaged<ITfInputScope2*, ushort**, int>)(lpVtbl[7]))((ITfInputScope2*)Unsafe.AsPointer(ref this), pbstrXML);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EnumWordList(IEnumString** ppEnumString)
        {
            return ((delegate* unmanaged<ITfInputScope2*, IEnumString**, int>)(lpVtbl[8]))((ITfInputScope2*)Unsafe.AsPointer(ref this), ppEnumString);
        }
    }
}
