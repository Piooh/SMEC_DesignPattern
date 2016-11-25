using UnityEngine;
using System.Collections;
using System.Collections.Generic;

using Assets.Lecture4;

namespace Assets.Lecture8
{
	public class Recorder : GenericMonoSingleton<Recorder>
	{
		private Queue<PlayableCommand> recordCommand = new Queue<PlayableCommand>();

		public bool IsEnd { get { return 0 == recordCommand.Count; } }

		public void Recording( PlayableCommand command )
		{
			recordCommand.Enqueue( command );
		}

		public void Play( ulong frame )
		{
			if( recordCommand.Peek().frame != frame ) { return; }

			var command = recordCommand.Dequeue();
			command.Excute();
		}
	}
}
