using UnityEngine;

namespace ReadOnlys
{
	public static class Lecture3
	{
		public enum Action 
		{
			Idle = 0,
			Attack = 1,
		}

		public class AnimationID
		{
			public static readonly int SwordState		= Animator.StringToHash("AnimationState");
			public static readonly int SwordWait		= Animator.StringToHash("Base Layer.Wait");
			public static readonly int SwordAttack		= Animator.StringToHash("Base Layer.Attack");
		}

		public static int ToInt( this Action action )
		{
			switch( action )
			{
				case Action.Attack:	return 1;

				case Action.Idle:
				default:						return 0;
			}
		}
	}
}
