// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("5F4633FE-1E08-4CB8-8C75-CE24333F5602")]
    public unsafe partial struct IDCompositionDesktopDevice
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDCompositionDesktopDevice* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDCompositionDesktopDevice* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDCompositionDesktopDevice* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Commit(IDCompositionDesktopDevice* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _WaitForCommitCompletion(IDCompositionDesktopDevice* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFrameStatistics(IDCompositionDesktopDevice* pThis, [NativeTypeName("DCOMPOSITION_FRAME_STATISTICS *")] DCOMPOSITION_FRAME_STATISTICS* statistics);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateVisual(IDCompositionDesktopDevice* pThis, [NativeTypeName("IDCompositionVisual2 **")] IDCompositionVisual2** visual);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateSurfaceFactory(IDCompositionDesktopDevice* pThis, [NativeTypeName("IUnknown *")] IUnknown* renderingDevice, [NativeTypeName("IDCompositionSurfaceFactory **")] IDCompositionSurfaceFactory** surfaceFactory);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateSurface(IDCompositionDesktopDevice* pThis, [NativeTypeName("UINT")] uint width, [NativeTypeName("UINT")] uint height, DXGI_FORMAT pixelFormat, DXGI_ALPHA_MODE alphaMode, [NativeTypeName("IDCompositionSurface **")] IDCompositionSurface** surface);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateVirtualSurface(IDCompositionDesktopDevice* pThis, [NativeTypeName("UINT")] uint initialWidth, [NativeTypeName("UINT")] uint initialHeight, DXGI_FORMAT pixelFormat, DXGI_ALPHA_MODE alphaMode, [NativeTypeName("IDCompositionVirtualSurface **")] IDCompositionVirtualSurface** virtualSurface);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateTranslateTransform(IDCompositionDesktopDevice* pThis, [NativeTypeName("IDCompositionTranslateTransform **")] IDCompositionTranslateTransform** translateTransform);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateScaleTransform(IDCompositionDesktopDevice* pThis, [NativeTypeName("IDCompositionScaleTransform **")] IDCompositionScaleTransform** scaleTransform);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateRotateTransform(IDCompositionDesktopDevice* pThis, [NativeTypeName("IDCompositionRotateTransform **")] IDCompositionRotateTransform** rotateTransform);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateSkewTransform(IDCompositionDesktopDevice* pThis, [NativeTypeName("IDCompositionSkewTransform **")] IDCompositionSkewTransform** skewTransform);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateMatrixTransform(IDCompositionDesktopDevice* pThis, [NativeTypeName("IDCompositionMatrixTransform **")] IDCompositionMatrixTransform** matrixTransform);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateTransformGroup(IDCompositionDesktopDevice* pThis, [NativeTypeName("IDCompositionTransform **")] IDCompositionTransform** transforms, [NativeTypeName("UINT")] uint elements, [NativeTypeName("IDCompositionTransform **")] IDCompositionTransform** transformGroup);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateTranslateTransform3D(IDCompositionDesktopDevice* pThis, [NativeTypeName("IDCompositionTranslateTransform3D **")] IDCompositionTranslateTransform3D** translateTransform3D);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateScaleTransform3D(IDCompositionDesktopDevice* pThis, [NativeTypeName("IDCompositionScaleTransform3D **")] IDCompositionScaleTransform3D** scaleTransform3D);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateRotateTransform3D(IDCompositionDesktopDevice* pThis, [NativeTypeName("IDCompositionRotateTransform3D **")] IDCompositionRotateTransform3D** rotateTransform3D);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateMatrixTransform3D(IDCompositionDesktopDevice* pThis, [NativeTypeName("IDCompositionMatrixTransform3D **")] IDCompositionMatrixTransform3D** matrixTransform3D);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateTransform3DGroup(IDCompositionDesktopDevice* pThis, [NativeTypeName("IDCompositionTransform3D **")] IDCompositionTransform3D** transforms3D, [NativeTypeName("UINT")] uint elements, [NativeTypeName("IDCompositionTransform3D **")] IDCompositionTransform3D** transform3DGroup);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateEffectGroup(IDCompositionDesktopDevice* pThis, [NativeTypeName("IDCompositionEffectGroup **")] IDCompositionEffectGroup** effectGroup);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateRectangleClip(IDCompositionDesktopDevice* pThis, [NativeTypeName("IDCompositionRectangleClip **")] IDCompositionRectangleClip** clip);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateAnimation(IDCompositionDesktopDevice* pThis, [NativeTypeName("IDCompositionAnimation **")] IDCompositionAnimation** animation);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateTargetForHwnd(IDCompositionDesktopDevice* pThis, [NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("BOOL")] int topmost, [NativeTypeName("IDCompositionTarget **")] IDCompositionTarget** target);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateSurfaceFromHandle(IDCompositionDesktopDevice* pThis, [NativeTypeName("HANDLE")] IntPtr handle, [NativeTypeName("IUnknown **")] IUnknown** surface);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateSurfaceFromHwnd(IDCompositionDesktopDevice* pThis, [NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("IUnknown **")] IUnknown** surface);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IDCompositionDesktopDevice*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IDCompositionDesktopDevice*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IDCompositionDesktopDevice*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Commit()
        {
            return Marshal.GetDelegateForFunctionPointer<_Commit>(lpVtbl->Commit)((IDCompositionDesktopDevice*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int WaitForCommitCompletion()
        {
            return Marshal.GetDelegateForFunctionPointer<_WaitForCommitCompletion>(lpVtbl->WaitForCommitCompletion)((IDCompositionDesktopDevice*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFrameStatistics([NativeTypeName("DCOMPOSITION_FRAME_STATISTICS *")] DCOMPOSITION_FRAME_STATISTICS* statistics)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFrameStatistics>(lpVtbl->GetFrameStatistics)((IDCompositionDesktopDevice*)Unsafe.AsPointer(ref this), statistics);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateVisual([NativeTypeName("IDCompositionVisual2 **")] IDCompositionVisual2** visual)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateVisual>(lpVtbl->CreateVisual)((IDCompositionDesktopDevice*)Unsafe.AsPointer(ref this), visual);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateSurfaceFactory([NativeTypeName("IUnknown *")] IUnknown* renderingDevice, [NativeTypeName("IDCompositionSurfaceFactory **")] IDCompositionSurfaceFactory** surfaceFactory)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateSurfaceFactory>(lpVtbl->CreateSurfaceFactory)((IDCompositionDesktopDevice*)Unsafe.AsPointer(ref this), renderingDevice, surfaceFactory);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateSurface([NativeTypeName("UINT")] uint width, [NativeTypeName("UINT")] uint height, DXGI_FORMAT pixelFormat, DXGI_ALPHA_MODE alphaMode, [NativeTypeName("IDCompositionSurface **")] IDCompositionSurface** surface)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateSurface>(lpVtbl->CreateSurface)((IDCompositionDesktopDevice*)Unsafe.AsPointer(ref this), width, height, pixelFormat, alphaMode, surface);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateVirtualSurface([NativeTypeName("UINT")] uint initialWidth, [NativeTypeName("UINT")] uint initialHeight, DXGI_FORMAT pixelFormat, DXGI_ALPHA_MODE alphaMode, [NativeTypeName("IDCompositionVirtualSurface **")] IDCompositionVirtualSurface** virtualSurface)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateVirtualSurface>(lpVtbl->CreateVirtualSurface)((IDCompositionDesktopDevice*)Unsafe.AsPointer(ref this), initialWidth, initialHeight, pixelFormat, alphaMode, virtualSurface);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateTranslateTransform([NativeTypeName("IDCompositionTranslateTransform **")] IDCompositionTranslateTransform** translateTransform)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateTranslateTransform>(lpVtbl->CreateTranslateTransform)((IDCompositionDesktopDevice*)Unsafe.AsPointer(ref this), translateTransform);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateScaleTransform([NativeTypeName("IDCompositionScaleTransform **")] IDCompositionScaleTransform** scaleTransform)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateScaleTransform>(lpVtbl->CreateScaleTransform)((IDCompositionDesktopDevice*)Unsafe.AsPointer(ref this), scaleTransform);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateRotateTransform([NativeTypeName("IDCompositionRotateTransform **")] IDCompositionRotateTransform** rotateTransform)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateRotateTransform>(lpVtbl->CreateRotateTransform)((IDCompositionDesktopDevice*)Unsafe.AsPointer(ref this), rotateTransform);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateSkewTransform([NativeTypeName("IDCompositionSkewTransform **")] IDCompositionSkewTransform** skewTransform)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateSkewTransform>(lpVtbl->CreateSkewTransform)((IDCompositionDesktopDevice*)Unsafe.AsPointer(ref this), skewTransform);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateMatrixTransform([NativeTypeName("IDCompositionMatrixTransform **")] IDCompositionMatrixTransform** matrixTransform)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateMatrixTransform>(lpVtbl->CreateMatrixTransform)((IDCompositionDesktopDevice*)Unsafe.AsPointer(ref this), matrixTransform);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateTransformGroup([NativeTypeName("IDCompositionTransform **")] IDCompositionTransform** transforms, [NativeTypeName("UINT")] uint elements, [NativeTypeName("IDCompositionTransform **")] IDCompositionTransform** transformGroup)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateTransformGroup>(lpVtbl->CreateTransformGroup)((IDCompositionDesktopDevice*)Unsafe.AsPointer(ref this), transforms, elements, transformGroup);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateTranslateTransform3D([NativeTypeName("IDCompositionTranslateTransform3D **")] IDCompositionTranslateTransform3D** translateTransform3D)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateTranslateTransform3D>(lpVtbl->CreateTranslateTransform3D)((IDCompositionDesktopDevice*)Unsafe.AsPointer(ref this), translateTransform3D);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateScaleTransform3D([NativeTypeName("IDCompositionScaleTransform3D **")] IDCompositionScaleTransform3D** scaleTransform3D)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateScaleTransform3D>(lpVtbl->CreateScaleTransform3D)((IDCompositionDesktopDevice*)Unsafe.AsPointer(ref this), scaleTransform3D);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateRotateTransform3D([NativeTypeName("IDCompositionRotateTransform3D **")] IDCompositionRotateTransform3D** rotateTransform3D)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateRotateTransform3D>(lpVtbl->CreateRotateTransform3D)((IDCompositionDesktopDevice*)Unsafe.AsPointer(ref this), rotateTransform3D);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateMatrixTransform3D([NativeTypeName("IDCompositionMatrixTransform3D **")] IDCompositionMatrixTransform3D** matrixTransform3D)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateMatrixTransform3D>(lpVtbl->CreateMatrixTransform3D)((IDCompositionDesktopDevice*)Unsafe.AsPointer(ref this), matrixTransform3D);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateTransform3DGroup([NativeTypeName("IDCompositionTransform3D **")] IDCompositionTransform3D** transforms3D, [NativeTypeName("UINT")] uint elements, [NativeTypeName("IDCompositionTransform3D **")] IDCompositionTransform3D** transform3DGroup)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateTransform3DGroup>(lpVtbl->CreateTransform3DGroup)((IDCompositionDesktopDevice*)Unsafe.AsPointer(ref this), transforms3D, elements, transform3DGroup);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateEffectGroup([NativeTypeName("IDCompositionEffectGroup **")] IDCompositionEffectGroup** effectGroup)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateEffectGroup>(lpVtbl->CreateEffectGroup)((IDCompositionDesktopDevice*)Unsafe.AsPointer(ref this), effectGroup);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateRectangleClip([NativeTypeName("IDCompositionRectangleClip **")] IDCompositionRectangleClip** clip)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateRectangleClip>(lpVtbl->CreateRectangleClip)((IDCompositionDesktopDevice*)Unsafe.AsPointer(ref this), clip);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateAnimation([NativeTypeName("IDCompositionAnimation **")] IDCompositionAnimation** animation)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateAnimation>(lpVtbl->CreateAnimation)((IDCompositionDesktopDevice*)Unsafe.AsPointer(ref this), animation);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateTargetForHwnd([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("BOOL")] int topmost, [NativeTypeName("IDCompositionTarget **")] IDCompositionTarget** target)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateTargetForHwnd>(lpVtbl->CreateTargetForHwnd)((IDCompositionDesktopDevice*)Unsafe.AsPointer(ref this), hwnd, topmost, target);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateSurfaceFromHandle([NativeTypeName("HANDLE")] IntPtr handle, [NativeTypeName("IUnknown **")] IUnknown** surface)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateSurfaceFromHandle>(lpVtbl->CreateSurfaceFromHandle)((IDCompositionDesktopDevice*)Unsafe.AsPointer(ref this), handle, surface);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateSurfaceFromHwnd([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("IUnknown **")] IUnknown** surface)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateSurfaceFromHwnd>(lpVtbl->CreateSurfaceFromHwnd)((IDCompositionDesktopDevice*)Unsafe.AsPointer(ref this), hwnd, surface);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr Commit;

            [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr WaitForCommitCompletion;

            [NativeTypeName("HRESULT (DCOMPOSITION_FRAME_STATISTICS *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetFrameStatistics;

            [NativeTypeName("HRESULT (IDCompositionVisual2 **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateVisual;

            [NativeTypeName("HRESULT (IUnknown *, IDCompositionSurfaceFactory **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateSurfaceFactory;

            [NativeTypeName("HRESULT (UINT, UINT, DXGI_FORMAT, DXGI_ALPHA_MODE, IDCompositionSurface **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateSurface;

            [NativeTypeName("HRESULT (UINT, UINT, DXGI_FORMAT, DXGI_ALPHA_MODE, IDCompositionVirtualSurface **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateVirtualSurface;

            [NativeTypeName("HRESULT (IDCompositionTranslateTransform **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateTranslateTransform;

            [NativeTypeName("HRESULT (IDCompositionScaleTransform **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateScaleTransform;

            [NativeTypeName("HRESULT (IDCompositionRotateTransform **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateRotateTransform;

            [NativeTypeName("HRESULT (IDCompositionSkewTransform **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateSkewTransform;

            [NativeTypeName("HRESULT (IDCompositionMatrixTransform **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateMatrixTransform;

            [NativeTypeName("HRESULT (IDCompositionTransform **, UINT, IDCompositionTransform **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateTransformGroup;

            [NativeTypeName("HRESULT (IDCompositionTranslateTransform3D **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateTranslateTransform3D;

            [NativeTypeName("HRESULT (IDCompositionScaleTransform3D **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateScaleTransform3D;

            [NativeTypeName("HRESULT (IDCompositionRotateTransform3D **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateRotateTransform3D;

            [NativeTypeName("HRESULT (IDCompositionMatrixTransform3D **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateMatrixTransform3D;

            [NativeTypeName("HRESULT (IDCompositionTransform3D **, UINT, IDCompositionTransform3D **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateTransform3DGroup;

            [NativeTypeName("HRESULT (IDCompositionEffectGroup **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateEffectGroup;

            [NativeTypeName("HRESULT (IDCompositionRectangleClip **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateRectangleClip;

            [NativeTypeName("HRESULT (IDCompositionAnimation **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateAnimation;

            [NativeTypeName("HRESULT (HWND, BOOL, IDCompositionTarget **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateTargetForHwnd;

            [NativeTypeName("HRESULT (HANDLE, IUnknown **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateSurfaceFromHandle;

            [NativeTypeName("HRESULT (HWND, IUnknown **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateSurfaceFromHwnd;
        }
    }
}
