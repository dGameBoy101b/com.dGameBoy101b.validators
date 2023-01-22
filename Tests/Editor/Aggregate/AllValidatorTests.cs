using NUnit.Framework;

namespace dGameBoy101b.Validators.EditorTests
{
	public class AllValidatorTests
	{
		private AllValidator validator;

		[SetUp]
		public void Setup()
		{
			this.validator = new AllValidator();
		}

		[Test]
		public void DefaultsToTrue()
		{
			Assert.IsTrue(this.validator.CheckValidity());
		}

		[Test]
		public void ReturnsFalseWithAllFalse()
		{
			this.validator.Validators.Add(new FalseValidator());
			Assert.IsFalse(this.validator.CheckValidity());
		}

		[Test]
		public void ReturnsTrueWithAllTrue()
		{
			this.validator.Validators.Add(new TrueValidator());
			Assert.IsTrue(this.validator.CheckValidity());
		}

		[Test]
		public void ReturnsFalseWithMixed()
		{
			this.validator.Validators.Add(new TrueValidator());
			this.validator.Validators.Add(new FalseValidator());
			Assert.IsFalse(this.validator.CheckValidity());
		}
	}
}
