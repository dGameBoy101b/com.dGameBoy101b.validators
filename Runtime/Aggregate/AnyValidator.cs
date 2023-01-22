namespace dGameBoy101b.Validators
{
	public sealed class AnyValidator : AggregateValidator
	{
		public override bool CheckValidity()
		{
			foreach (var validator in this.Validators)
				if (validator.CheckValidity())
					return true;
			return false;
		}
	}
}
