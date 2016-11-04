using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Lecture5
{
	public struct Skill
	{
		public static Skill Create( string name, int unlockLevel, int damage, int consumeMP, float cooltime )
		{
			Skill newSkill = new Skill();

			newSkill.name				= name;
			newSkill.unlockLevel		= unlockLevel;
			newSkill.damage			= damage;
			newSkill.consumeMP	= consumeMP;
			newSkill.coolTime			= cooltime;
			newSkill.point				= 0;
			return  newSkill;
		}

		public string name;
		public int unlockLevel;
		public int damage;
		public int consumeMP;
		public float coolTime;
		public int point;
	}
}
