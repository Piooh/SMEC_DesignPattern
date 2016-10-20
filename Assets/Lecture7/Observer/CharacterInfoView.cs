using UnityEngine;
using System.Collections;

using Assets.Lecture5;

namespace Assets.Lecture7
{
	public class CharacterInfoView : MonoBehaviour
													, IObserver<AvatarInfo>
	{
		private void Awake()
		{
			PlayerInfoAlarm.Register( this );
		}

		public void UpdateAlarm( AvatarInfo data )
		{
		}
	}
}
