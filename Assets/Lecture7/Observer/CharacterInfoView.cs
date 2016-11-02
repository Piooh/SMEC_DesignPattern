using UnityEngine;
using UnityEngine.UI;
using System.Collections;

using Assets.Lecture5;

namespace Assets.Lecture7
{
	public class CharacterInfoView : MonoBehaviour
													, IObserver<AvatarInfo>
	{
		public Text lblName			= null;
		public Text lblLevel			= null;
		public Text lblExp				= null;
		public Text lblHp				= null;
		public Text lblMp				= null;
		
		private void Awake()
		{
			PlayerInfoAlarm.Register( this );

			Debug.Assert( null != lblName );
			Debug.Assert( null != lblLevel );
			Debug.Assert(null != lblExp);

			Empty();
		}

		public void UpdateAlarm( AvatarInfo data )
		{
			lblName.text		= "Nick Name : " + data.nickName;
			lblLevel.text		= "Level : " + data.level;
			lblExp.text			= "Exp : " + data.exp;
			lblHp.text			= "Hp : " + data.hp;
			lblMp.text			= "Mp : " + data.mp;
		}

		public void Empty()
		{
			lblName.text		= "Nick Name : ";
			lblLevel.text		= "Level : ";
			lblExp.text			= "Exp : ";
			lblHp.text			= "Hp : "; 
			lblMp.text			= "Mp : ";
		}
	}
}
