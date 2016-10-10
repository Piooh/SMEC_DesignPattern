using UnityEngine;
using System.Collections.Generic;
using System;

namespace Assets.Lecture5
{
	public class Dragon : Monster
	{
		private List<IFX> fxList = new List<IFX>();

		public override void SetupFactor()
		{
			//[todo];
			Factor = new MonsterFactors();
		}

		public override  void RegisterFX( IFXFactory fxMaker )
		{
			var aura			= fxMaker.CreateAura();
			aura.transform.parent = transform;
			fxList.Add( aura );

			var spell		= fxMaker.CreateSpell();
			spell.transform.parent = transform;
			fxList.Add( spell );


			var magic		= fxMaker.CreateMagic();
			magic.transform.parent = transform;
			fxList.Add( magic );
		}

		public override void SetRespawn()
		{
		}
	}
}
