using NUnit.Framework;

namespace dGameBoy101b.Validators.EditorTests
{
	public class FalseValidatorTests
	{
		private FalseValidator validator;

		[SetUp]
		public void Setup()
		{
			this.validator = new FalseValidator();
		}

		[Test]
		public void AlwaysFalse()
		{
			Assert.IsFalse(this.validator.CheckValidity());
		}
	}
}
