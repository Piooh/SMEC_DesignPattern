using UnityEngine;

public class VerySimpleMonoSingleton : MonoBehaviour
{
	public static VerySimpleMonoSingleton instance = null;

	private void Awake()
	{
		instance = this;
	}
}
