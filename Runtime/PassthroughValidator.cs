namespace dGameBoy101b.Validators
{
	[System.Serializable]
	public class PassthroughValidator : Validator
	{
		public bool IsValid { get; set; }

		public override bool CheckValidity()
		{
			return this.IsValid;
		}
	}
}
