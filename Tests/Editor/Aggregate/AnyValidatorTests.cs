using NUnit.Framework;
using UnityEngine;

namespace dGameBoy101b.Validators.EditorTests
{
	public class AnyValidatorTests
	{
		AnyValidator validator;

		[SetUp]
		public void Setup()
		{
			var obj = new GameObject();
			this.validator = obj.AddComponent<AnyValidator>();
		}

		[Test]
		public void DefaultsToFalse()
		{
			Assert.IsFalse(this.validator.CheckValidity());
		}

		[Test]
		public void ReturnsTrueWithAllTrue()
		{
			var obj = new GameObject();
			var input = obj.AddComponent<TrueValidator>();
			this.validator.Validators.Add(input);
			Assert.IsTrue(this.validator.CheckValidity());
		}

		[Test]
		public void ReturnsFalseWithAllFalse()
		{
			var obj = new GameObject();
			var input = obj.AddComponent<FalseValidator>();
			this.validator.Validators.Add(input);
			Assert.IsFalse(this.validator.CheckValidity());
		}

		[Test]
		public void ReturnsTrueWithMixed()
		{
			var obj = new GameObject();
			var true_val = obj.AddComponent<TrueValidator>();
			var false_val = obj.AddComponent<FalseValidator>();
			this.validator.Validators.Add(true_val);
			this.validator.Validators.Add(false_val);
			Assert.IsTrue(this.validator.CheckValidity());
		}
	}
}
