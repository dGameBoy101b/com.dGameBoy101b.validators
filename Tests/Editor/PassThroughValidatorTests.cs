using NUnit.Framework;
using UnityEngine;

namespace dGameBoy101b.Validators.EditorTests
{
	public class PassthroughValidatorTests
	{
		private PassthroughValidator validator;

		[SetUp]
		public void Setup()
		{
			var obj = new GameObject();
			this.validator = obj.AddComponent<PassthroughValidator>();
		}

		[Test]
		public void DefaultsToFalse()
		{
			Assert.IsFalse(this.validator.CheckValidity());
		}

		[Test]
		public void ReturnsTrueWhenSetToTrue()
		{
			this.validator.IsValid = true;
			Assert.IsTrue(this.validator.CheckValidity());
		}

		[Test]
		public void ReturnsFalseWhenSetToFalse()
		{
			this.validator.IsValid = false;
			Assert.IsFalse(this.validator.CheckValidity());
		}
	}
}
