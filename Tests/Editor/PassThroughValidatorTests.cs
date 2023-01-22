using NUnit.Framework;

namespace dGameBoy101b.Validators.EditorTests
{
	public class PassthroughValidatorTests
	{
		private PassthroughValidator validator;

		[SetUp]
		public void Setup()
		{
			this.validator = new PassthroughValidator();
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
