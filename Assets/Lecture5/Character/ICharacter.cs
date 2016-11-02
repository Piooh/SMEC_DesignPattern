
namespace Assets.Lecture5
{
	public interface ICharacter
	{
		void SetAvatarInfo();
		void SetRespawn();
		void RegisterFX( IFXFactory fxMaker );
	}

}
