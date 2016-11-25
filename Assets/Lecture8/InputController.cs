using UnityEngine;
using System.Collections;

using Assets.Lecture5;

namespace Assets.Lecture8
{
	public class InputController : MonoBehaviour
	{	
		public SwordMan character = null;
		public bool IsPressKey		{ get{ return Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow);} }

		private ulong frame = 0;
		private bool isPlay = false;
		private Vector3 prevPos = Vector3.zero;

		private void Update()
		{
			frame++;
		}
	
		private void LateUpdate()
		{
			if( false == isPlay )
			{
				if( true == IsPressKey )
				{
					float vertical = Input.GetAxis("Vertical");
					float horizontal = Input.GetAxis("Horizontal");

					var dir = new Vector3( horizontal, 0.0f, vertical );//((Vector3.right * horizontal ) + (Vector3.forward * vertical )).normalized;
					dir.Normalize();
					PlayableCommand command = new MoveCommand( character, dir, frame );
					Recorder.Instance.Recording( command );
					command.Excute();
				}
			}
			else
			{
				if( true == Recorder.Instance.IsEnd )
				{
					isPlay = false;
					frame = 0;
					return;
				}

				Recorder.Instance.Play( frame );
			}
		}

		public void Play()
		{
			isPlay = true;
			frame = 0;
			var savePos = character.transform.position;

			character.transform.rotation = Quaternion.identity;
			character.transform.position = prevPos;
			prevPos = savePos;
		}
	}
}

