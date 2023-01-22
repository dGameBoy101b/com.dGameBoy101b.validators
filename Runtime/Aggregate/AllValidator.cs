namespace dGameBoy101b.Validators
{
	public sealed class AllValidator : AggregateValidator
	{
		public override bool CheckValidity()
		{
			foreach (var validator in this.Validators)
				if (!validator.CheckValidity())
					return false;
			return true;
		}
	}
}
