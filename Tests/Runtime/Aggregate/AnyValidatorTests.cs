using NUnit.Framework;
using UnityEngine;

namespace dGameBoy101b.Validators.PlayTests
{
	public class AnyValidatorTests
	{
		private AnyValidator validator;
		private GameObject game_object;

		[SetUp]
		public void Setup()
		{
			this.game_object = new GameObject();
			this.validator = this.game_object.AddComponent<AnyValidator>();
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
		public void ReturnsTrueWithAllTrue()
		{
			var input = this.game_object.AddComponent<TrueValidator>();
			this.validator.Validators.Add(input);
			Assert.IsTrue(this.validator.CheckValidity());
		}

		[Test]
		public void ReturnsFalseWithAllFalse()
		{
			var input = this.game_object.AddComponent<FalseValidator>();
			this.validator.Validators.Add(input);
			Assert.IsFalse(this.validator.CheckValidity());
		}

		[Test]
		public void ReturnsTrueWithMixed()
		{
			var true_val = this.game_object.AddComponent<TrueValidator>();
			var false_val = this.game_object.AddComponent<FalseValidator>();
			this.validator.Validators.Add(true_val);
			this.validator.Validators.Add(false_val);
			Assert.IsTrue(this.validator.CheckValidity());
		}
	}
}
