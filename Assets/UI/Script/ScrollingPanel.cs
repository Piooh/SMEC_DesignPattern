using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollingPanel : UIPanel
{
	public RectTransform contentsRect		= null;
	public GameObject contentsPrefab		= null;

	public Vector2 contentBaseSize				= new Vector2(100f, 100f);
	public Vector2 contentOffsetSize			= new Vector2(5f, 5f);

	public bool IsInit									{ get; protected set; }
	public float ScrollingSize						{ get; set; }
	public int TotalContentCount					{ get; set; }

	public float ContentsWidth
	{
		get
		{
			if ( null == contentsPrefab ) { return contentBaseSize.x; }
			else
			{
				CalcContents();

				return contentsSize.width;
			}
		}
	}
	public float ContentsHeight
	{
		get
		{
			if ( null == contentsPrefab ) { return contentBaseSize.y; }
			else
			{
				CalcContents();

				return contentsSize.height;
			}
		}
	}
	public virtual int InstantCount
	{
		get
		{
			if( false == IsInit ) { Initialize(); }
			if( 0 == instantCount )
			{
				if( true == scrollRect.vertical && false == scrollRect.horizontal )
				{
					var height = ContentsHeight + contentOffsetSize.y;
					instantCount =  Mathf.RoundToInt(Height / height);
				}
				else if( false == scrollRect.horizontal && true == scrollRect.horizontal )
				{
				}
				else
				{
				}
			}

			return instantCount;
		}
	}

	protected ScrollRect scrollRect				= null;
	protected Rect contentsSize					= Rect.zero;
	private int instantCount						= 0;

	protected override void Awake()
	{
		TotalContentCount = 10;
		FillContent();
	}

	protected virtual void Initialize()
	{
		if( true == IsInit ) { return; }

		scrollRect				= gameObject.GetComponent<ScrollRect>();
		Debug.Assert( null != scrollRect );
		Debug.Assert( null != contentsRect );
		Debug.Assert( null != contentsPrefab );

		IsInit						= true;
	}

	protected virtual void CalcContents()
	{
		if( Rect.zero != contentsSize )		{ return; }
		var trans			= contentsPrefab.transform as RectTransform;
		contentsSize		= null == trans ? new Rect( Vector2.zero, contentBaseSize ) : trans.rect;
	}

	protected virtual void CalcScrollingSize()
	{
		if( true == scrollRect.vertical && false == scrollRect.horizontal )
		{
			ScrollingSize	= TotalContentCount * ( ContentsHeight + contentOffsetSize.y );
			var size			= contentsRect.sizeDelta;
			size.y				= ScrollingSize;

			contentsRect.sizeDelta = size;
		}
		else if( false == scrollRect.horizontal && true == scrollRect.horizontal )
		{
		}
		else
		{
		}
	}

	public virtual void FillContent()
	{
		if( false == IsInit )	{ Initialize(); }

		CalcScrollingSize();

		Vector3 dir			= true == scrollRect.horizontal ? Vector3.right : Vector3.down;
		float size			= true == scrollRect.horizontal ? (ContentsWidth + contentOffsetSize.x) : (ContentsHeight + contentOffsetSize.y);
		float halfSize		= size * 0.5f;

		Vector3 pos		= Vector3.zero + (dir * halfSize);

		for( int i = 0; i < InstantCount; i++)
		{
			var item			= Instantiate<GameObject>( contentsPrefab, Vector3.zero, Quaternion.identity, contentsRect  );
			item.transform.localPosition = pos + (dir * size * i);
			item.name		= string.Format( "Item_{0:000}", i );

			Debug.LogError( string.Format("{0} : {1}", i,  item.transform.localPosition  ));
		}
	}

	public virtual void UpdateContent()
	{
		float size							= (ContentsHeight + contentOffsetSize.y);
		var scrollviewRect				= scrollRect.transform as RectTransform;
		var extent							= size * instantCount;
		var halfExtents					= extent * 0.5f;
		var scrollCenter					= contentsRect.InverseTransformPoint( scrollviewRect.position );

		for( int i = 0; i < InstantCount; i++ )
		{
			var content					= contentsRect.GetChild( i );
			var pos						= content.localPosition;
			var dist						= (pos.y - scrollCenter.y);
		
			Debug.LogError( "ScrollCenter : " + scrollCenter + ", halfHeight : " + halfExtents  + ", dist : " + dist );
			Debug.LogError( "[ "+i+" ] contentPos : " + pos );

			if( dist < -halfExtents )
			{
				Debug.LogWarning( "[ "+i+" ]bottom out : " + content.name  + ", conetnt pos : " + pos );
				pos.y							= pos.y + extent;
				var index					= -Mathf.FloorToInt(pos.y / size);
				if( index >= 0 && TotalContentCount >= index )
				{
					content.localPosition	= pos;
				}
			}
			else if( dist > halfExtents )
			{
				Debug.LogWarning( "[ "+i+" ]top out : " + content.name  + ", conetnt pos : " + pos );
				pos.y							= pos.y - extent;
				var index					= -Mathf.FloorToInt(pos.y / size);
				if( index >= 0 && TotalContentCount >= index )
				{
					content.localPosition	= pos;
				}
			}
		}
	}
}
