// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xamlOM.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IXamlDiagnostics" /> struct.</summary>
    public static unsafe class IXamlDiagnosticsTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IXamlDiagnostics" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IXamlDiagnostics).GUID, Is.EqualTo(IID_IXamlDiagnostics));
        }

        /// <summary>Validates that the <see cref="IXamlDiagnostics" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IXamlDiagnostics>(), Is.EqualTo(sizeof(IXamlDiagnostics)));
        }

        /// <summary>Validates that the <see cref="IXamlDiagnostics" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IXamlDiagnostics).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IXamlDiagnostics" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IXamlDiagnostics), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IXamlDiagnostics), Is.EqualTo(4));
            }
        }
    }
}
