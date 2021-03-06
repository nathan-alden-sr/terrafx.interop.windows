// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum MF_TOPOLOGY_TYPE
    {
        MF_TOPOLOGY_OUTPUT_NODE = 0,
        MF_TOPOLOGY_SOURCESTREAM_NODE = (MF_TOPOLOGY_OUTPUT_NODE + 1),
        MF_TOPOLOGY_TRANSFORM_NODE = (MF_TOPOLOGY_SOURCESTREAM_NODE + 1),
        MF_TOPOLOGY_TEE_NODE = (MF_TOPOLOGY_TRANSFORM_NODE + 1),
        MF_TOPOLOGY_MAX = unchecked((int)(0xffffffff)),
    }
}
