using NUnit.Framework;

namespace dGameBoy101b.Validators.EditorTests
{
	public class TrueValidatorTests
	{
		private TrueValidator validator;
		
		[SetUp]
		public void Setup()
		{
			this.validator = new TrueValidator();
		}

		[Test]
		public void AlwaysTrue()
		{
			Assert.IsTrue(this.validator.CheckValidity());
		}
	}
}
