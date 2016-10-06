﻿using UnityEngine;


namespace Assets.Lecture5
{
	public interface ICharacter
	{
		string Name { get; set; }
		void RegisterFX( IFXFactory fxMaker );
		void SetRespawn();
	}

}
