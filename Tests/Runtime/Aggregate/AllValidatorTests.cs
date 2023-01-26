using NUnit.Framework;
using UnityEngine;

namespace dGameBoy101b.Validators.PlayTests
{
	public class AllValidatorTests
	{
		private AllValidator validator;
		private GameObject game_object;

		[SetUp]
		public void Setup()
		{
			this.game_object = new GameObject();
			this.validator = game_object.AddComponent<AllValidator>();
		}

		[TearDown]
		public void Teardown()
		{
			Object.Destroy(this.game_object);
		}

		[Test]
		public void DefaultsToTrue()
		{
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
		public void ReturnsTrueWithAllTrue()
		{
			var input = this.game_object.AddComponent<TrueValidator>();
			this.validator.Validators.Add(input);
			Assert.IsTrue(this.validator.CheckValidity());
		}

		[Test]
		public void ReturnsFalseWithMixed()
		{
			var true_val = this.game_object.AddComponent<TrueValidator>();
			var false_val = this.game_object.AddComponent<FalseValidator>();
			this.validator.Validators.Add(true_val);
			this.validator.Validators.Add(false_val);
			Assert.IsFalse(this.validator.CheckValidity());
		}
	}
}
