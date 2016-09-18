using System.Collections;


namespace Assets.Lecture3
{
	public interface ISoldierAction
	{
		void Attack();
		IEnumerator CheckAniEnd();
	}
}
