using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Lecture5
{
	public struct PlayerAchieve
	{
		public static PlayerAchieve Create( string name, string desc, int state, int max )
		{
			PlayerAchieve achieve = new PlayerAchieve();
			achieve.name = name;
			achieve.desc = desc;
			achieve.state = state;
			achieve.max	= max;

			return achieve;
		}

		public string name;
		public string desc;
		public int state;
		public int progress;
		public int max;
	}
}
