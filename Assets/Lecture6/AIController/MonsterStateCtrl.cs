using UnityEngine;
using System.Collections;

using Assets.Lecture5;

namespace Assets.Lecture6
{
	public class MonsterStateCtrl : MonoBehaviour
	{
		private Monster mob									= null;

		private IMonsterBehavior CurrentState			{ get; set; }
		private IMonsterBehavior PrevState				{ get; set; }

		private void Awake()
		{
			mob					= GetComponent<Monster>();
		}

		private void Update()
		{
			if( null == mob )						{ return; }
			
			if( null != CurrentState )			{ CurrentState.Update( this, mob ); }
		}

		public void ChangeBehavior( IMonsterBehavior state )
		{
			if( CurrentState == state )					{ return; }

			PrevState = CurrentState;

			if( null != CurrentState )
			{
				CurrentState.Exit( this, mob );
			}

			CurrentState = state;

			if( null != CurrentState )
			{
				CurrentState.Enter( this, mob );
			}
		}
	}
}
