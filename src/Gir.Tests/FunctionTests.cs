﻿using System;
using NUnit.Framework;

namespace Gir.Tests
{
	[TestFixture]
	public class FunctionTests : GenerationTestBase
	{
		[Test]
		public void TestRecordFunctionIsGenerated()
		{
			// Test is incomplete, as record is not fully generated atm.
			var result = GenerateMember(GLib, "ByteArray", "append");

			Assert.AreEqual(@"///<summary>
/// Adds the given bytes to the end of the #GByteArray.
/// The array will grow in size automatically if necessary.
///</summary>
///<returns>the #GByteArray</returns>
static void append PARAMS
", result);
		}
	}
}