using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

using Assets.Lecture5;

namespace Assets.Lecture7
{
	public class CharacterAchieveView : MonoBehaviour
															, IObserver<AvatarInfo>
	{
		public List<Text> achieveList = new List<Text>();

		private void Awake()
		{
			PlayerInfoAlarm.Register( this );
		}

		public void Empty()
		{
			for( int i = 0; i < achieveList.Count; i++ )
			{
				achieveList[i].text = string.Empty;
			}
		}

		public void UpdateAlarm( AvatarInfo data )
		{
			var parentTrans = transform as RectTransform;
			PlayerAchieve achieve;
			for( int i = 0; i< data.achieveList.Count; i++ )
			{
				achieve = data.achieveList[i];
				if( i < achieveList.Count )
				{
					achieveList[i].text = string.Format( "{0}\n{1}\n{2} / {3}  {4:P1}", achieve.name, achieve.desc, achieve.progress, achieve.max, achieve.progress / achieve.max );
				}
				else
				{
					var go = new GameObject(string.Format("AchieveItem_{0:000}", i));
					go.transform.SetParent( parentTrans );

					var text = go.AddComponent<Text>();
					text.text = string.Format( "{0}\n{1}\n{2} / {3}  {4:P1}", achieve.name, achieve.desc, achieve.progress, achieve.max, achieve.progress / achieve.max );
					text.color = Color.black;
					text.font = Resources.GetBuiltinResource( typeof(Font), "Arial.ttf" ) as Font;
					text.alignment = TextAnchor.UpperLeft;

					var fit = go.AddComponent<ContentSizeFitter>();
					fit.horizontalFit = ContentSizeFitter.FitMode.PreferredSize;
					fit.verticalFit = ContentSizeFitter.FitMode.PreferredSize;
					achieveList.Add( text );
				}

				var pos = Vector3.zero;
				pos.x = (parentTrans.rect.width * 0.5f) + parentTrans.localPosition.x + (achieveList[i].preferredWidth * 0.5f);
				pos.y = parentTrans.rect.height + parentTrans.localPosition.y - (achieveList[i].preferredHeight * (i + 1));
				achieveList[i].rectTransform.localPosition = pos;
			}
		}
	}
}