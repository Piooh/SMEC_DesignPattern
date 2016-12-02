using UnityEngine;
using System.Collections;

using Assets.Lecture5;

namespace Assets.Lecture8
{
	public class InputController : MonoBehaviour
	{	
		public SwordMan character = null;
		public bool IsPressKey		{ get{ return Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow);} }

		private Vector3 prevPos = Vector3.zero;

		private void LateUpdate()
		{
			if( true == IsPressKey && false == Recorder.Instance.IsPlay )
				{
					float vertical = Input.GetAxis("Vertical");
					float horizontal = Input.GetAxis("Horizontal");

					var dir = new Vector3( horizontal, 0.0f, vertical );//((Vector3.right * horizontal ) + (Vector3.forward * vertical )).normalized;
					dir.Normalize();
					PlayableCommand command = new MoveCommand( character, dir );
					Recorder.Instance.Recording( command );
					command.Excute();
				}
		}

		public void Play()
		{
			var savePos								= character.transform.position;
			character.transform.rotation		= Quaternion.identity;
			character.transform.position		= prevPos;
			prevPos = savePos;

			Recorder.Instance.Play();
		}
	}
}

