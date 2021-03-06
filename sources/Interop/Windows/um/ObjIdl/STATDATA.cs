// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct STATDATA
    {
        public FORMATETC formatetc;

        [NativeTypeName("DWORD")]
        public uint advf;

        public IAdviseSink* pAdvSink;

        [NativeTypeName("DWORD")]
        public uint dwConnection;
    }
}
