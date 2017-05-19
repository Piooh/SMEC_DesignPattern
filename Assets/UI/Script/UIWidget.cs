using UnityEngine;

public class UIWidget : MonoBehaviour
{
	public virtual RectTransform RectTrans		{ get{ return transform as RectTransform; } }
	public virtual float Width							{ get{ return null == RectTrans ? 0 : RectTrans.sizeDelta.x; } }
	public virtual float Height							{ get{ return null == RectTrans ? 0 : RectTrans.sizeDelta.y; } }
	public virtual bool IsShow							{ get{ return gameObject.activeSelf; } }

	public void Show( bool active = true, params object[] options )
	{
		gameObject.SetActive( active );

		DoShow( active, options );
	}

    protected virtual void Awake()					{ }
    protected virtual void OnEnable()				{ }
	protected virtual void Update()					{ }
	protected virtual void OnDisable()				{ }
	protected virtual void OnDestroy()				{ }

	protected virtual void DoShow( bool active, params object[] options )
	{
	}
}
