// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("DBB84C27-36CE-4FC9-B801-F048C46AC570")]
    [NativeTypeName("struct ID3D12MetaCommand : ID3D12Pageable")]
    public unsafe partial struct ID3D12MetaCommand
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D12MetaCommand*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12MetaCommand*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D12MetaCommand*, uint>)(lpVtbl[1]))((ID3D12MetaCommand*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID3D12MetaCommand*, uint>)(lpVtbl[2]))((ID3D12MetaCommand*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT *")] uint* pDataSize, [NativeTypeName("void *")] void* pData)
        {
            return ((delegate* unmanaged<ID3D12MetaCommand*, Guid*, uint*, void*, int>)(lpVtbl[3]))((ID3D12MetaCommand*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return ((delegate* unmanaged<ID3D12MetaCommand*, Guid*, uint, void*, int>)(lpVtbl[4]))((ID3D12MetaCommand*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
        {
            return ((delegate* unmanaged<ID3D12MetaCommand*, Guid*, IUnknown*, int>)(lpVtbl[5]))((ID3D12MetaCommand*)Unsafe.AsPointer(ref this), guid, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetName([NativeTypeName("LPCWSTR")] ushort* Name)
        {
            return ((delegate* unmanaged<ID3D12MetaCommand*, ushort*, int>)(lpVtbl[6]))((ID3D12MetaCommand*)Unsafe.AsPointer(ref this), Name);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDevice([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvDevice)
        {
            return ((delegate* unmanaged<ID3D12MetaCommand*, Guid*, void**, int>)(lpVtbl[7]))((ID3D12MetaCommand*)Unsafe.AsPointer(ref this), riid, ppvDevice);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("UINT64")]
        public ulong GetRequiredParameterResourceSize(D3D12_META_COMMAND_PARAMETER_STAGE Stage, [NativeTypeName("UINT")] uint ParameterIndex)
        {
            return ((delegate* unmanaged<ID3D12MetaCommand*, D3D12_META_COMMAND_PARAMETER_STAGE, uint, ulong>)(lpVtbl[8]))((ID3D12MetaCommand*)Unsafe.AsPointer(ref this), Stage, ParameterIndex);
        }
    }
}
