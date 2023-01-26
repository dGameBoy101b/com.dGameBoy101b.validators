using NUnit.Framework;
using UnityEngine;

namespace dGameBoy101b.Validators.PlayTests
{
	public class PassthroughValidatorTests
	{
		private PassthroughValidator validator;
		private GameObject game_object;

		[SetUp]
		public void Setup()
		{
			this.game_object = new GameObject();
			this.validator = this.game_object.AddComponent<PassthroughValidator>();
		}

		[TearDown]
		public void Teardown()
		{
			Object.Destroy(this.game_object);
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
