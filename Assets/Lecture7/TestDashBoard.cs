using UnityEngine;
using System.Collections;

using Assets.Lecture5;
using Assets.Lecture7;

public class TestDashBoard : MonoBehaviour
{
	private Solider swordMan = null;

	private void Awake()
	{
		swordMan = Barrucks.Instance.GetSolider(Assets.Lecture3.ReadOnlys.CharacterType.SwordMan) as Solider;
	}

	private void Start()
	{
		PlayerInfoAlarm.Notify( swordMan.Info );
	}

	public void OnClickLevelup()
	{
		if( null == swordMan )				{ return; }

		swordMan.Info.LevelUP();
		PlayerInfoAlarm.Notify( swordMan.Info );
	}
}
