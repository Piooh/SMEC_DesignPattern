using UnityEngine;
using System.Collections;

using Assets.Lecture5;

namespace Assets.Lecture6
{
	public class SlimeAICtrl : MonoBehaviour
	{
		private RoamingAround roamAround = new RoamingAround();
		private Monster mob	= null;

		private void Awake()
		{
			mob					= GetComponent<Monster>();
		}

		private void Update()
		{
			if( null == mob ) { return; }
			
			roamAround.Update( mob );
		}
	}
}
