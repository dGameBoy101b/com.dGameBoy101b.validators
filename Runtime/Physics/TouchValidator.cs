using System.Collections.Generic;
using UnityEngine;

namespace dGameBoy101b.Validators
{
	public class TouchValidator : ValidatorBase
	{
		[SerializeField]
		[Tooltip("The layer mask used to filter touching colliders")]
		public LayerMask Mask;

		private HashSet<Collider> _touchingColliders = new HashSet<Collider>();
		
		public IReadOnlyCollection<Collider> TouchingColliders { get => this._touchingColliders; }

		public override bool CheckValidity()
		{
			return this.TouchingColliders.Count > 0;
		}

		protected virtual void TouchCollider(in Collider collider)
		{
			if (((1 << collider.gameObject.layer) & this.Mask.value) > 0)
				this._touchingColliders.Add(collider);
		}

		protected virtual void UntouchCollider(in Collider collider)
		{
			this._touchingColliders.Remove(collider);
		}

		private void OnCollisionEnter(Collision collision)
		{
			this.TouchCollider(collision.collider);
		}

		private void OnCollisionExit(Collision collision)
		{
			this.UntouchCollider(collision.collider);
		}

		private void OnTriggerEnter(Collider other)
		{
			this.TouchCollider(other);
		}

		private void OnTriggerExit(Collider other)
		{
			this.UntouchCollider(other);
		}
	}
}