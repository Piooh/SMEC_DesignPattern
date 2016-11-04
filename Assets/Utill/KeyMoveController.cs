using UnityEngine;

namespace Assets.Utill
{
	public class KeyMoveController : MonoBehaviour
	{
		public float moveSpeed = 10f;

		private void FixedUpdate()
		{
			var dir = new Vector3( Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical") );
			
			
			transform.rotation = 0 == dir.magnitude ? transform.rotation :  Quaternion.LookRotation( dir );
			transform.position = transform.position + (dir * moveSpeed * Time.fixedDeltaTime );
		}
	}
}
