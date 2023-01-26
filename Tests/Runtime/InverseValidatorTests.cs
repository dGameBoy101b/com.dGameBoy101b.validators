using NUnit.Framework;
using UnityEngine;

namespace dGameBoy101b.Validators.PlayTests
{
	public class InverseValidatorTests
	{
		private InverseValidator validator;
		private GameObject game_object;

		[SetUp]
		public void Setup()
		{
			this.game_object = new GameObject();
			this.validator = this.game_object.AddComponent<InverseValidator>();
		}

		[TearDown]
		public void Teardown()
		{
			Object.Destroy(this.game_object);
		}

		[Test]
		public void ReturnsFalseWhenInputTrue()
		{
			var obj = new GameObject();
			this.validator.Validator = obj.AddComponent<TrueValidator>();
			Assert.IsFalse(this.validator.CheckValidity());
		}

		[Test]
		public void ReturnsTrueWhenInputFalse()
		{
			var obj = new GameObject();
			this.validator.Validator = obj.AddComponent<FalseValidator>();
			Assert.IsTrue(this.validator.CheckValidity());
		}
	}
}
