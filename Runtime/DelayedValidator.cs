using UnityEngine;

namespace dGameBoy101b.Validators
{
	public sealed class DelayedValidator : ValidatorBase
	{
		[SerializeField]
		[Tooltip("The number of seconds between the source validator passing and this passing")]
		[Min(0)]
		private float _passDelay = 0;

		public float PassDelay { get => this._passDelay; set => this._passDelay = Mathf.Max(0, value); }

		[SerializeField]
		[Tooltip("The number of seconds between the source validator failing and this failing")]
		[Min(0)]
		private float _failDelay = 0;

		public float FailDelay { get => this._failDelay; set => this._failDelay = Mathf.Max(0, value); }

		[SerializeField]
		[Tooltip("The validator whose validity will be delayed")]
		private ValidatorBase SourceValidator;

		public float LastChange { get; private set; }

		public bool HadPassed { get; private set; }

		public override bool CheckValidity()
		{
			return (Time.time - this.LastChange) < (this.HadPassed ? this.PassDelay : this.FailDelay) ^ this.HadPassed;
		}

		private void UpdateValidity()
		{
			bool has_passed = this.SourceValidator.CheckValidity();
			if (this.HadPassed ^ !has_passed)
				return;
			this.LastChange = Time.time;
			this.HadPassed = has_passed;
		}

		private void Update()
		{
			this.UpdateValidity();
		}
	}
}