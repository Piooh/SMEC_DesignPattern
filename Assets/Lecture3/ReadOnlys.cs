using UnityEngine;

namespace Assets.Lecture3.ReadOnlys
{
	public enum Action 
	{
		Idle = 0,
		Attack = 1,
	}

	public class AnimationID
	{
		public static readonly int AniState		= Animator.StringToHash("AnimationState");
		public static readonly int Idle				= Animator.StringToHash("Base Layer.Idle");
		public static readonly int Attack			= Animator.StringToHash("Base Layer.Attack");
	}

	public static class EnumExtension
	{
		public static int ToInt( this Action action )
		{
			//return System.Convert.ToInt32( action );

			switch( action )
			{
				case Action.Attack:	return 1;

				case Action.Idle:
				default:						return 0;
			}
		}
	}
}
