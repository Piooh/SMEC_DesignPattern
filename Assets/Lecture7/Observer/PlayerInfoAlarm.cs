using UnityEngine;
using System.Collections.Generic;

using Assets.Lecture5;

namespace Assets.Lecture7
{
	using AlarmReceiver = IObserver<AvatarInfo>;

	public class PlayerInfoAlarm
	{
		public static void Register( AlarmReceiver newTarget )
		{
			if( true == instance.AddReceiver( newTarget ) )
			{
				Debug.Log( "Register Success !");
			}
			else
			{
				Debug.LogError( "Register Fail !");
			}
		}

		public static void Unregister( AlarmReceiver delTarget )
		{
			if( true == instance.DelReceiver( delTarget ) )
			{
				Debug.Log( "Unregister Success !");
			}
			else
			{
				Debug.LogError( "Unregister Fail !");
			}
		}

		public static void Notify( AvatarInfo data  )
		{
			instance.UpdateReceiver( data );
		}

		private static PlayerInfoAlarm instance		= new PlayerInfoAlarm();

		private List<AlarmReceiver> receiverList	= new List<AlarmReceiver>();

		private bool AddReceiver( AlarmReceiver newTarget )
		{
			if( false == receiverList.Contains(newTarget) )
			{
				receiverList.Add( newTarget );
				return true;
			}

			return false;
		}

		private bool DelReceiver( AlarmReceiver newTarget )
		{
			if( true == receiverList.Contains(newTarget) )
			{
				return receiverList.Remove( newTarget );
			}

			return false;
		}


		private void UpdateReceiver( AvatarInfo data )
		{
			for( int i = 0; i < receiverList.Count; i++ )
			{
				receiverList[i].UpdateAlarm( data );
			}
		}
	}
}
