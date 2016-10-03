
namespace Assets.Lecture5
{
	public interface IFXFactory
	{
		FXAura CreateAura();
		FXSpell CreateSpell();
		FXMagic CreateMagic();
	}
}
