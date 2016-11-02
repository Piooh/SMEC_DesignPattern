using UnityEngine;
using System.Collections.Generic;
using System;

namespace Assets.Lecture5
{
	public class Witch : Solider
	{
		private List<IFX> fxList = new List<IFX>();

		public override void RegisterFX( IFXFactory fxMaker )
		{
			var aura			= fxMaker.CreateAura();
			aura.transform.parent = transform;
			fxList.Add( aura );


			var magic		= fxMaker.CreateMagic();
			magic.transform.parent = transform;
			fxList.Add( magic );
		}

		public override void SetAvatarInfo()
		{
		}

		public override void SetRespawn()
		{
			transform.position = Vector3.right * 10f;
		}
	}
}
