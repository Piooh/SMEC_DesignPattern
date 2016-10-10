using UnityEngine;
using System.Collections.Generic;

using Assets.Lecture3;

namespace Assets.Lecture5
{
	public class SwordMan : Solider
	{
		private List<IFX>		fxList				= new List<IFX>();

		public override void RegisterFX( IFXFactory fxMaker )
		{
			var aura			= fxMaker.CreateAura();
			aura.transform.parent = transform;
			fxList.Add( aura );


			var spell			= fxMaker.CreateSpell();
			spell.transform.parent = transform;
			fxList.Add( spell );
		}

		public override void SetRespawn()
		{
			transform.position = Vector3.left * 10f;
		}
	}
}
