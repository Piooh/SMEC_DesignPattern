using UnityEngine;

using Assets.Lecture5;

namespace Assets.Lecture8
{
	public class MoveCommand : PlayableCommand
	{
		private Solider player	= null;
		private Vector3 dir		= Vector3.zero;
		
		public MoveCommand( Solider solider, Vector3 _dir, ulong _frame )
		{
			player		= solider;
			dir			= _dir;
			frame		= _frame;			
		}

		public MoveCommand( Solider solider, Vector3 _dir )
		{
			player		= solider;
			dir			= _dir;
			frame		= 0;
		}

		public override void Excute()
		{
			player.Move( dir );
		}
	}
}
