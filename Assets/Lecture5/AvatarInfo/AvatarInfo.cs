using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Lecture5
{
	public class AvatarInfo
	{
		public string nickName;
		public int level;
		public float exp;
		public float maxEXP;

		public float hp;
		public float maxHP;
		public float mp;
		public float maxMP;

		public List<Skill> skillList							= new List<Skill>();
		public List<PlayerAchieve> achieveList	= new List<PlayerAchieve>();

		public AvatarInfo( string name )
		{
			nickName		= name;
			level				= 0;
			exp				= 0;

			CreateSkill();
			CreateAchieve();
		}

		public virtual void LevelUP()
		{
			level++;
			maxEXP = 100f * level;
		}

		protected virtual void CreateSkill()
		{
		}

		protected virtual void CreateAchieve()
		{
		}
	}
}
