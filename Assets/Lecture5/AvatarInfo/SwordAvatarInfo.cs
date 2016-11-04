using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Assets.Lecture5.Factors;

namespace Assets.Lecture5
{
	public class SwordAvatarInfo : AvatarInfo
	{
		public SwordAvatarFactor factor = new SwordAvatarFactor();

		public SwordAvatarInfo( string name ) : base(name)
		{
			LevelUP();
		}

		protected override void CreateSkill()
		{
			skillList.Add( Skill.Create("Double Attack", 2, 10, 3, 2f ) );
			skillList.Add( Skill.Create("Provoke", 5, 2, 1, 1f ) );
			skillList.Add( Skill.Create("Critical Strike", 7, 30, 7, 3f ) );
			skillList.Add( Skill.Create("Defence UP", 9, 3, 2, 5f ) );
			skillList.Add( Skill.Create("Big Fucking Damage", 12, 100, 10, 10f ) );
		}

		protected override void CreateAchieve()
		{
			achieveList.Add( PlayerAchieve.Create("Arrive to Lv2", "bla bla bla", 0, 2) );
			achieveList.Add( PlayerAchieve.Create("Arrive to Lv10", "bla bla bla", 0, 10) );
			achieveList.Add( PlayerAchieve.Create("Arrive to Lv20", "bla bla bla", 0, 20) );
			achieveList.Add( PlayerAchieve.Create("Kill Slime", "bla bla bla", 0, 30) );
			achieveList.Add( PlayerAchieve.Create("Kill Dragon", "bla bla bla", 0, 1) );
			achieveList.Add( PlayerAchieve.Create("Learn to Critical Sktrike", "bla bla bla", 0, 7) );
		}

		public override void LevelUP()
		{
			base.LevelUP();

			maxHP = maxHP + ( 100f * level * factor.MaxHPBonusFactor );
			maxMP = maxMP + ( 50f * level * factor.MaxMPBonusFactor );

			hp		= maxHP;
			mp		= maxMP;
		}
	}
}
