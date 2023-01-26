using NUnit.Framework;
using UnityEngine;

namespace dGameBoy101b.Validators.EditorTests
{
	public class TrueValidatorTests
	{
		private TrueValidator validator;
		
		[SetUp]
		public void Setup()
		{
			var obj = new GameObject();
			this.validator = obj.AddComponent<TrueValidator>();
		}

		[Test]
		public void AlwaysTrue()
		{
			Assert.IsTrue(this.validator.CheckValidity());
		}
	}
}
