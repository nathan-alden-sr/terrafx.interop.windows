// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="GDI_OBJECT" /> struct.</summary>
    public static unsafe class GDI_OBJECTTests
    {
        /// <summary>Validates that the <see cref="GDI_OBJECT" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<GDI_OBJECT>(), Is.EqualTo(sizeof(GDI_OBJECT)));
        }

        /// <summary>Validates that the <see cref="GDI_OBJECT" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(GDI_OBJECT).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="GDI_OBJECT" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(GDI_OBJECT), Is.EqualTo(16));
            }
            else
            {
                Assert.That(sizeof(GDI_OBJECT), Is.EqualTo(8));
            }
        }
    }
}