using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace dGameBoy101b.Validators.PlayTests
{
	public class DelayedValidatorTests
	{
		private DelayedValidator validator;
		private PassthroughValidator input;
		private GameObject game_object;

		[SetUp]
		public void Setup()
		{
			this.game_object = new GameObject();
			this.validator = this.game_object.AddComponent<DelayedValidator>();
			this.input = this.game_object.AddComponent<PassthroughValidator>();
			this.validator.SourceValidator = this.input;
		}

		[TearDown]
		public void Teardown()
		{
			Object.Destroy(this.game_object);
		}

		[UnityTest]
		public IEnumerator SwitchesToTrueAfterPassDelay()
		{
			const float TOLERANCE = .01f;
			const float PASS_DELAY = 1;
			this.validator.PassDelay = PASS_DELAY;
			this.input.IsValid = false;
			yield return null;
			Assert.IsFalse(this.validator.CheckValidity());
			this.input.IsValid = true;
			yield return null;
			Assert.IsFalse(this.validator.CheckValidity());
			float time = 0;
			while (!this.validator.CheckValidity())
			{
				yield return null;
				time += Time.deltaTime;
			}
			Assert.That(time, Is.EqualTo(PASS_DELAY).Within(TOLERANCE));
		}

		[UnityTest]
		public IEnumerator SwitchesToFalseAfterFailDelay()
		{
			const float TOLERANCE = .01f;
			const float FAIL_DELAY = 1;
			this.validator.FailDelay = FAIL_DELAY;
			this.input.IsValid = true;
			yield return null;
			Assert.IsTrue(this.validator.CheckValidity());
			this.input.IsValid = false;
			yield return null;
			Assert.IsTrue(this.validator.CheckValidity());
			float time = 0;
			while (this.validator.CheckValidity())
			{
				yield return null;
				time += Time.deltaTime;
			}
			Assert.That(time, Is.EqualTo(FAIL_DELAY).Within(TOLERANCE));
		}
	}
}
