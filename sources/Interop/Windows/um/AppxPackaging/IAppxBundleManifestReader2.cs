// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("5517DF70-033F-4AF2-8213-87D766805C02")]
    [NativeTypeName("struct IAppxBundleManifestReader2 : IUnknown")]
    public unsafe partial struct IAppxBundleManifestReader2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAppxBundleManifestReader2*, Guid*, void**, int>)(lpVtbl[0]))((IAppxBundleManifestReader2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppxBundleManifestReader2*, uint>)(lpVtbl[1]))((IAppxBundleManifestReader2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppxBundleManifestReader2*, uint>)(lpVtbl[2]))((IAppxBundleManifestReader2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetOptionalBundles(IAppxBundleManifestOptionalBundleInfoEnumerator** optionalBundles)
        {
            return ((delegate* unmanaged<IAppxBundleManifestReader2*, IAppxBundleManifestOptionalBundleInfoEnumerator**, int>)(lpVtbl[3]))((IAppxBundleManifestReader2*)Unsafe.AsPointer(ref this), optionalBundles);
        }
    }
}
