using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

using Assets.Lecture5;

namespace Assets.Lecture7
{
	public class CharacterSkillView : MonoBehaviour
													, IObserver<AvatarInfo>
	{
		public List<Text> skillList		= new List<Text>();

		private void Awake()
		{
			PlayerInfoAlarm.Register( this );
		}

		public void UpdateAlarm( AvatarInfo data )
		{
		}
	}
}
