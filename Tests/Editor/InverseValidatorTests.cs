using NUnit.Framework;

namespace dGameBoy101b.Validators.EditorTests
{
	public class InverseValidatorTests
	{
		private InverseValidator validator;

		[SetUp]
		public void Setup()
		{
			this.validator = new InverseValidator();
		}

		[Test]
		public void ReturnsFalseWhenInputTrue()
		{
			this.validator.Validator = new TrueValidator();
			Assert.IsFalse(this.validator.CheckValidity());
		}

		[Test]
		public void ReturnsTrueWhenInputFalse()
		{
			this.validator.Validator = new FalseValidator();
			Assert.IsTrue(this.validator.CheckValidity());
		}
	}
}
