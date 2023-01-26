using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace dGameBoy101b.Validators.EditorTests
{
	public class DelayedValidatorTests
	{
		private DelayedValidator validator;
		private PassthroughValidator input;

		[SetUp]
		public void Setup()
		{
			var obj = new GameObject();
			this.validator = obj.AddComponent<DelayedValidator>();
			this.input = obj.AddComponent<PassthroughValidator>();
			this.validator.SourceValidator = this.input;
		}

		[UnityTest]
		public IEnumerator SwitchesToTrueAfterPassDelay()
		{
			const float PASS_DELAY = 1f;
			this.validator.PassDelay = PASS_DELAY;
			this.input.IsValid = false;
			yield return null;
			Assert.IsFalse(this.validator.CheckValidity());
			this.input.IsValid = true;
			yield return new WaitForSeconds(PASS_DELAY / 2f);
			Assert.IsFalse(this.validator.CheckValidity());
			yield return new WaitForSeconds(PASS_DELAY / 2f);
			Assert.IsTrue(this.validator.CheckValidity());
		}

		[UnityTest]
		public IEnumerator SwitchesToFalseAfterFailDelay()
		{
			const float FAIL_DELAY = 1f;
			this.validator.FailDelay = FAIL_DELAY;
			this.input.IsValid = true;
			yield return null;
			Assert.IsTrue(this.validator.CheckValidity());
			this.input.IsValid = false;
			yield return new WaitForSeconds(FAIL_DELAY / 2f);
			Assert.IsTrue(this.validator.CheckValidity());
			yield return new WaitForSeconds(FAIL_DELAY / 2f);
			Assert.IsFalse(this.validator.CheckValidity());
		}
	}
}
