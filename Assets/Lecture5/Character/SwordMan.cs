using UnityEngine;
using System.Collections.Generic;

using Assets.Lecture3;

namespace Assets.Lecture5
{
	public class SwordMan : MonoBehaviour
									, ISolider
	{
		public string Name { get; set; }

		private List<IFX>		fxList				= new List<IFX>();

		public void RegisterFX( IFXFactory fxMaker )
		{
			var aura			= fxMaker.CreateAura();
			aura.transform.parent = transform;
			fxList.Add( aura );


			var spell			= fxMaker.CreateSpell();
			spell.transform.parent = transform;
			fxList.Add( spell );
		}

		public void SetRespawn()
		{
			transform.position = Vector3.left * 10f;
		}
	}
}
