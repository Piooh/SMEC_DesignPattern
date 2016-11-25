using UnityEngine;
using System.Collections;

public class CamController : MonoBehaviour
{
	public Transform target		= null;

	private Camera cam				= null;
	private Vector3 offset			= Vector3.zero;

	private void Awake()
	{
		cam = GetComponent<Camera>();
		offset = target.position - transform.position; 
	}
	private void LateUpdate()
	{
		float currentAngle = transform.eulerAngles.y;
		float desiredAngle = target.eulerAngles.y;
		float angle = Mathf.LerpAngle(currentAngle, desiredAngle, Time.deltaTime);

		Quaternion rotation = Quaternion.Euler(0, angle, 0);
		transform.position = target.position - (rotation * offset );		
		transform.LookAt( target );
	}
}
