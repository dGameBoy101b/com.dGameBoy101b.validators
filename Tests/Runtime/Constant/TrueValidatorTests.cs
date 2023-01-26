using NUnit.Framework;
using UnityEngine;

namespace dGameBoy101b.Validators.PlayTests
{
	public class TrueValidatorTests
	{
		private TrueValidator validator;
		private GameObject game_object;
		
		[SetUp]
		public void Setup()
		{
			this.game_object = new GameObject();
			this.validator = this.game_object.AddComponent<TrueValidator>();
		}

		[TearDown]
		public void Teardown()
		{
			Object.Destroy(this.game_object);
		}

		[Test]
		public void AlwaysTrue()
		{
			Assert.IsTrue(this.validator.CheckValidity());
		}
	}
}
