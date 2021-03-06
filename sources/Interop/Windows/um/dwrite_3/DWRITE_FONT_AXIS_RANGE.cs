// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct DWRITE_FONT_AXIS_RANGE
    {
        public DWRITE_FONT_AXIS_TAG axisTag;

        [NativeTypeName("FLOAT")]
        public float minValue;

        [NativeTypeName("FLOAT")]
        public float maxValue;
    }
}
