using UnityEngine;
using System.Collections;
using System.Collections.Generic;

using Assets.Lecture4;

namespace Assets.Lecture8
{
	public class Recorder : GenericMonoSingleton<Recorder>
	{
		private ulong frame																	= 0;
		private Queue<PlayableCommand> recordCommand			= new Queue<PlayableCommand>();

		public bool IsPlay				{ get; private set; }		

		public void Recording( PlayableCommand command )
		{
			command.frame						= frame;
			recordCommand.Enqueue( command );
		}

		public void Play()
		{
			IsPlay			= true;
			frame			= 0;
		}

		private void Update()
		{
			if( true == IsPlay )
			{
				PlayRecording();
			}

			frame++;
		}

		private void PlayRecording()
		{
			if( 0 == recordCommand.Count )
			{
				IsPlay = false;
			}
			else
			{
				if( recordCommand.Peek().frame != frame )			{ return;  }

				var command = recordCommand.Dequeue();
				command.Excute();
			}
		}
	}
}
