// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1effectauthor.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>Describes options transforms may select to use on their input textures.</summary>
    public struct D2D1_INPUT_DESCRIPTION
    {
        #region Fields
        public D2D1_FILTER filter;

        [NativeTypeName("UINT32")]
        public uint levelOfDetailCount;
        #endregion
    }
}
