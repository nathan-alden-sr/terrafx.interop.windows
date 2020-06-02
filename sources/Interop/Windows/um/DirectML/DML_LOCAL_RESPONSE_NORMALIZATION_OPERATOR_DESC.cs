// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DirectML.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct DML_LOCAL_RESPONSE_NORMALIZATION_OPERATOR_DESC
    {
        [NativeTypeName("const DML_TENSOR_DESC *")]
        public DML_TENSOR_DESC* InputTensor;

        [NativeTypeName("const DML_TENSOR_DESC *")]
        public DML_TENSOR_DESC* OutputTensor;

        [NativeTypeName("BOOL")]
        public int CrossChannel;

        [NativeTypeName("UINT")]
        public uint LocalSize;

        [NativeTypeName("FLOAT")]
        public float Alpha;

        [NativeTypeName("FLOAT")]
        public float Beta;

        [NativeTypeName("FLOAT")]
        public float Bias;
    }
}
