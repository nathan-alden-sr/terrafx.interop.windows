// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct RTL_BARRIER
    {
        [NativeTypeName("DWORD")]
        public uint Reserved1;

        [NativeTypeName("DWORD")]
        public uint Reserved2;

        [NativeTypeName("ULONG_PTR [2]")]
        public _Reserved3_e__FixedBuffer Reserved3;

        [NativeTypeName("DWORD")]
        public uint Reserved4;

        [NativeTypeName("DWORD")]
        public uint Reserved5;

        public partial struct _Reserved3_e__FixedBuffer
        {
            internal UIntPtr e0;
            internal UIntPtr e1;

            public ref UIntPtr this[int index] => ref AsSpan()[index];

            public Span<UIntPtr> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 2);
        }
    }
}