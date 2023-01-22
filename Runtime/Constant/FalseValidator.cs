namespace dGameBoy101b.Validators
{
	public sealed class FalseValidator : ValidatorBase
	{
		public override bool CheckValidity()
		{
			return false;
		}
	}
}