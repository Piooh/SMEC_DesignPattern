using UnityEngine;
using System.Collections.Generic;

namespace Assets.Lecture5
{
	public class Dragon : MonoBehaviour
								, IMonster
	{
		public string Name { get; set; }

		private List<IFX> fxList = new List<IFX>();

		public void RegisterFX( IFXFactory fxMaker )
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

		public void SetRespawn()
		{
		}
	}
}
