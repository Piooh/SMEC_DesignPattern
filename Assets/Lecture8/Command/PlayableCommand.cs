using UnityEngine;
using System.Collections;

namespace Assets.Lecture8
{
	public abstract class PlayableCommand : ICommand
	{
		public ulong frame = 0;
		public abstract  void Excute();
	}
}
