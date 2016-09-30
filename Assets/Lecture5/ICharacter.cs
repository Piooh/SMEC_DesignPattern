
namespace Assets.Lecture5
{
	public interface ICharacter
	{
		string Name { get; set; }
		void LoadPrefab();
	}

	public interface ISolider : ICharacter
	{
	}



	//public class Archer : ICharacter
	//{
	//	public string Name		{ get; set; }
	//	public void Init()			{ Name = "Archer"; }
	//}


	//public class Rabbit : ICharacter
	//{
	//	public string Name		{ get; set; }
	//	public void Init()			{ Name = "Rabbit"; }
	//}

	//public class Slime : ICharacter
	//{
	//	public string Name		{ get; set; }
	//	public void Init()			{ Name = "Slime"; }
	//}

	//public class Dragon : ICharacter
	//{
	//	public string Name		{ get; set; }
	//	public void Init()			{ Name = "Dragon"; }
	//}
}
