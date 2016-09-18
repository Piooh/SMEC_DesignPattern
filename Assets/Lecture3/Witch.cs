
namespace Assets.Lecture3
{
	public class Witch : Solider
	{
		protected override void InitAction()
		{
			attackAction = WitchAction.Get( animator );
		}
	}
}
