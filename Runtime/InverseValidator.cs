using UnityEngine;

namespace dGameBoy101b.Validators
{
	public sealed class InverseValidator : Validator
	{
		[SerializeField]
		[Tooltip("The validator to invert")]
		public Validator Validator = null;

		public override bool CheckValidity()
		{
			return !this.Validator.CheckValidity();
		}
	}
}
