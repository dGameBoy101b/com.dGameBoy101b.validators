using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace dGameBoy101b.Validators.EditorTests
{
	public class AnyValidatorTests
	{
		AnyValidator validator;

		[SetUp]
		public void Setup()
		{
			this.validator = new AnyValidator();
		}

		[Test]
		public void DefaultsToFalse()
		{
			Assert.IsFalse(this.validator.CheckValidity());
		}

		[Test]
		public void ReturnsTrueWithAllTrue()
		{
			this.validator.Validators.Add(new TrueValidator());
			Assert.IsTrue(this.validator.CheckValidity());
		}

		[Test]
		public void ReturnsFalseWithAllFalse()
		{
			this.validator.Validators.Add(new FalseValidator());
			Assert.IsFalse(this.validator.CheckValidity());
		}

		[Test]
		public void ReturnsTrueWithMixed()
		{
			this.validator.Validators.Add(new TrueValidator());
			this.validator.Validators.Add(new FalseValidator());
			Assert.IsTrue(this.validator.CheckValidity());
		}
	}
}
