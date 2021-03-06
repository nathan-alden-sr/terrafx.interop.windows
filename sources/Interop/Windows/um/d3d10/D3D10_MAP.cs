// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d10.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum D3D10_MAP
    {
        D3D10_MAP_READ = 1,
        D3D10_MAP_WRITE = 2,
        D3D10_MAP_READ_WRITE = 3,
        D3D10_MAP_WRITE_DISCARD = 4,
        D3D10_MAP_WRITE_NO_OVERWRITE = 5,
    }
}
