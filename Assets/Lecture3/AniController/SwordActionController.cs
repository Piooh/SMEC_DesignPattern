
namespace Assets.Lecture3
{
	public class SwordActionController : AniActionController
	{
		protected override void InitAction()
		{
			attackAction = SwordAction.Get( animator );
			//attackAction = WitchAction.Get( animator );
		}
	}
}
