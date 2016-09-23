
namespace Assets.Lecture5
{
	public interface ICharacter
	{
		string Name { get; set;  }

		void Init();
	}

	public class SwordMan : ICharacter
	{
		public string Name		{ get; set; }
		public void Init()			{ Name = "SwordMan"; }
	}

	public class Magician : ICharacter
	{
		public string Name		{ get; set; }
		public void Init()			{ Name = "Magician"; }
	}

	public class Archer : ICharacter
	{
		public string Name		{ get; set; }
		public void Init()			{ Name = "Archer"; }
	}

	
	public class Rabbit : ICharacter
	{
		public string Name		{ get; set; }
		public void Init()			{ Name = "Rabbit"; }
	}

	public class Slime : ICharacter
	{
		public string Name		{ get; set; }
		public void Init()			{ Name = "Slime"; }
	}

	public class Dragon : ICharacter
	{
		public string Name		{ get; set; }
		public void Init()			{ Name = "Dragon"; }
	}
}
