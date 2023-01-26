using NUnit.Framework;
using UnityEngine;

namespace dGameBoy101b.Validators.EditorTests
{
	public class InverseValidatorTests
	{
		private InverseValidator validator;

		[SetUp]
		public void Setup()
		{
			var obj = new GameObject();
			this.validator = obj.AddComponent<InverseValidator>();
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
