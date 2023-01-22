namespace dGameBoy101b.Validators
{
	public sealed class FalseValidator : Validator
	{
		public override bool CheckValidity()
		{
			return false;
		}
	}
}