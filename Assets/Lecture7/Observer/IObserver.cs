using UnityEngine;
using System.Collections;

namespace Assets.Lecture7
{
	public interface IObserver<T> 
	{
		void UpdateAlarm( T data );
	}
}