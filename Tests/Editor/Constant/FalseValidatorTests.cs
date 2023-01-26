using NUnit.Framework;
using UnityEngine;

namespace dGameBoy101b.Validators.EditorTests
{
	public class FalseValidatorTests
	{
		private FalseValidator validator;

		[SetUp]
		public void Setup()
		{
			var obj = new GameObject();
			this.validator = obj.AddComponent<FalseValidator>();
		}

		[Test]
		public void AlwaysFalse()
		{
			Assert.IsFalse(this.validator.CheckValidity());
		}
	}
}
