using UnityEngine;

namespace dGameBoy101b.Validators
{
	public class RaycastValidator : ValidatorBase
	{
		[SerializeField]
		[Tooltip("The maximum distance to raycast")]
		public float MaximumDistance = Mathf.Infinity;

		[SerializeField]
		[Tooltip("The mask used to filter collisions")]
		public LayerMask Mask;

		[SerializeField]
		[Tooltip("How to interact with triggers")]
		public QueryTriggerInteraction TriggerInteraction;

		public override bool CheckValidity()
		{
			return Physics.Raycast(this.transform.position, this.transform.forward, this.MaximumDistance, this.Mask, this.TriggerInteraction);
		}
	}
}
