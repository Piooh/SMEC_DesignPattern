using UnityEngine;
using System.Collections.Generic;

namespace Assets.Lecture5
{
	public class Witch : MonoBehaviour
							, ISolider
	{
		public string Name { get; set; }
		private List<IFX> fxList = new List<IFX>();

		public void RegisterFX( IFXFactory fxMaker )
		{
			var aura			= fxMaker.CreateAura();
			aura.transform.parent = transform;
			fxList.Add( aura );


			var magic		= fxMaker.CreateMagic();
			magic.transform.parent = transform;
			fxList.Add( magic );
		}

		public void SetRespawn()
		{
			transform.position = Vector3.right * 10f;
		}
	}
}
