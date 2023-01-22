using UnityEngine;

namespace dGameBoy101b.Validators
{
	public sealed class InverseValidator : ValidatorBase
	{
		[SerializeField]
		[Tooltip("The validator to invert")]
		public ValidatorBase Validator = null;

		public override bool CheckValidity()
		{
			return !this.Validator.CheckValidity();
		}
	}
}
