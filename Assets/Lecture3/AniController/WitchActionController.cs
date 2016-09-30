
namespace Assets.Lecture3
{
	public class WitchActionController : AniActionController
	{
		protected override void InitAction()
		{
			attackAction = WitchAction.Get( animator );
		}
	}
}
