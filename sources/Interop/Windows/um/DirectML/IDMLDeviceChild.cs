// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DirectML.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("27E83142-8165-49E3-974E-2FD66E4CB69D")]
    public unsafe partial struct IDMLDeviceChild
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDMLDeviceChild* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDMLDeviceChild* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDMLDeviceChild* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetPrivateData(IDMLDeviceChild* pThis, [NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT *")] uint* dataSize, [NativeTypeName("void *")] void* data);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPrivateData(IDMLDeviceChild* pThis, [NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT")] uint dataSize, [NativeTypeName("const void *")] void* data);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPrivateDataInterface(IDMLDeviceChild* pThis, [NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("IUnknown *")] IUnknown* data);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetName(IDMLDeviceChild* pThis, [NativeTypeName("PCWSTR")] ushort* name);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDevice(IDMLDeviceChild* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IDMLDeviceChild*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IDMLDeviceChild*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IDMLDeviceChild*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT *")] uint* dataSize, [NativeTypeName("void *")] void* data)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetPrivateData>(lpVtbl->GetPrivateData)((IDMLDeviceChild*)Unsafe.AsPointer(ref this), guid, dataSize, data);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT")] uint dataSize, [NativeTypeName("const void *")] void* data)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetPrivateData>(lpVtbl->SetPrivateData)((IDMLDeviceChild*)Unsafe.AsPointer(ref this), guid, dataSize, data);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("IUnknown *")] IUnknown* data)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetPrivateDataInterface>(lpVtbl->SetPrivateDataInterface)((IDMLDeviceChild*)Unsafe.AsPointer(ref this), guid, data);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetName([NativeTypeName("PCWSTR")] ushort* name)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetName>(lpVtbl->SetName)((IDMLDeviceChild*)Unsafe.AsPointer(ref this), name);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDevice([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetDevice>(lpVtbl->GetDevice)((IDMLDeviceChild*)Unsafe.AsPointer(ref this), riid, ppv);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (const GUID &, UINT *, void *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetPrivateData;

            [NativeTypeName("HRESULT (const GUID &, UINT, const void *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetPrivateData;

            [NativeTypeName("HRESULT (const GUID &, IUnknown *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetPrivateDataInterface;

            [NativeTypeName("HRESULT (PCWSTR) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetName;

            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetDevice;
        }
    }
}
