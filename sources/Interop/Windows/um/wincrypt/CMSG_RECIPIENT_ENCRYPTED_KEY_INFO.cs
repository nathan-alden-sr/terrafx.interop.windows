// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct CMSG_RECIPIENT_ENCRYPTED_KEY_INFO
    {
        public CERT_ID RecipientId;

        [NativeTypeName("CRYPT_DATA_BLOB")]
        public CRYPTOAPI_BLOB EncryptedKey;

        public FILETIME Date;

        [NativeTypeName("PCRYPT_ATTRIBUTE_TYPE_VALUE")]
        public CRYPT_ATTRIBUTE_TYPE_VALUE* pOtherAttr;
    }
}
