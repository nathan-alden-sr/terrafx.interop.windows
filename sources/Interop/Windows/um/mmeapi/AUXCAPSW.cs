// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mmeapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe partial struct AUXCAPSW
    {
        [NativeTypeName("WORD")]
        public ushort wMid;

        [NativeTypeName("WORD")]
        public ushort wPid;

        [NativeTypeName("MMVERSION")]
        public uint vDriverVersion;

        [NativeTypeName("WCHAR [32]")]
        public fixed ushort szPname[32];

        [NativeTypeName("WORD")]
        public ushort wTechnology;

        [NativeTypeName("WORD")]
        public ushort wReserved1;

        [NativeTypeName("DWORD")]
        public uint dwSupport;
    }
}
