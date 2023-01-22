using System.Collections.Generic;
using UnityEngine;

namespace dGameBoy101b.Validators
{
	public abstract class AggregateValidator : Validator
	{
		[SerializeField]
		[Tooltip("The validators this aggregates")]
		public List<Validator> Validators = new List<Validator>();
	}
}
