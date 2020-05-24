// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IDWriteStringList" /> struct.</summary>
    public static class IDWriteStringListTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IDWriteStringList" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IDWriteStringList).GUID, Is.EqualTo(IID_IDWriteStringList));
        }

        /// <summary>Validates that the layout of the <see cref="IDWriteStringList" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IDWriteStringList).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the size of the <see cref="IDWriteStringList" /> struct is correct.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(Marshal.SizeOf<IDWriteStringList>(), Is.EqualTo(8));
            }
            else
            {
                Assert.That(Marshal.SizeOf<IDWriteStringList>(), Is.EqualTo(4));
            }
        }

        /// <summary>Provides validation of the <see cref="IDWriteStringList.Vtbl" /> struct.</summary>
        public static class VtblTests
        {
            /// <summary>Validates that the layout of the <see cref="IDWriteStringList" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
            [Test]
            public static void IsLayoutSequentialTest()
            {
                Assert.That(typeof(IDWriteStringList.Vtbl).IsLayoutSequential, Is.True);
            }

            /// <summary>Validates that the size of the <see cref="IDWriteStringList" /> struct is correct.</summary>
            [Test]
            public static void SizeOfTest()
            {
                if (Environment.Is64BitProcess)
                {
                    Assert.That(Marshal.SizeOf<IDWriteStringList.Vtbl>(), Is.EqualTo(64));
                }
                else
                {
                    Assert.That(Marshal.SizeOf<IDWriteStringList.Vtbl>(), Is.EqualTo(32));
                }
            }
        }
    }
}