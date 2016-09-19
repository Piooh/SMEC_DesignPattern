using UnityEngine;

public class ReformMonoSingleton : MonoBehaviour
{
	private static ReformMonoSingleton instance = null;

	public static ReformMonoSingleton Instance
	{
		get
		{
			if( null == instance )
			{
				instance = GameObject.FindObjectOfType<ReformMonoSingleton>();
				if( null == instance )
				{
					var go			= new GameObject("ReformMonoSingleton");
					instance		= go.AddComponent<ReformMonoSingleton>();
					DontDestroyOnLoad(go);
				}
			}

			return instance;
		}
	}

	private void Awake()
	{
		if( null != instance )
		{
			Destroy(this);
		}
		else
		{
			instance = this;
			DontDestroyOnLoad(gameObject);
		}
	}
}
