using NUnit.Framework;
using UnityEngine;

namespace dGameBoy101b.Validators.PlayTests
{
	public class FalseValidatorTests
	{
		private FalseValidator validator;
		private GameObject game_object;

		[SetUp]
		public void Setup()
		{
			this.game_object = new GameObject();
			this.validator = this.game_object.AddComponent<FalseValidator>();
		}

		[TearDown]
		public void Teardown()
		{
			Object.Destroy(this.game_object);
		}

		[Test]
		public void AlwaysFalse()
		{
			Assert.IsFalse(this.validator.CheckValidity());
		}
	}
}
