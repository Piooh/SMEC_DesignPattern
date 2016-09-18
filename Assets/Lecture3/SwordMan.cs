
namespace Assets.Lecture3
{
	public class SwordMan : Solider
	{
		protected override void InitAction()
		{
			attackAction = SwordAction.Get( animator );
		}
	}
}
