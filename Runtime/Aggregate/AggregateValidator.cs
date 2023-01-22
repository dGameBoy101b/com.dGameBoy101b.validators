using System.Collections.Generic;
using UnityEngine;

namespace dGameBoy101b.Validators
{
	public abstract class AggregateValidator : ValidatorBase
	{
		[SerializeField]
		[Tooltip("The validators this aggregates")]
		public List<ValidatorBase> Validators = new List<ValidatorBase>();
	}
}
