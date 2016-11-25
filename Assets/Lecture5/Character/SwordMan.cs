using UnityEngine;
using System.Collections.Generic;

using Assets.Lecture3;
using System;
using Assets.Lecture8;

namespace Assets.Lecture5
{
	public class SwordMan : Solider
	{
		private List<IFX>		fxList				= new List<IFX>();
		private SphereCollider collider		= null;

		private float moveSpeed			= 10f;

		private void Awake()
		{
			collider = GetComponent<SphereCollider>();
		}

		public override void RegisterFX( IFXFactory fxMaker )
		{
			var aura			= fxMaker.CreateAura();
			aura.transform.parent = transform;
			fxList.Add( aura );

			var spell			= fxMaker.CreateSpell();
			spell.transform.parent = transform;
			fxList.Add( spell );
		}

		public override void SetAvatarInfo()
		{
			Info = new SwordAvatarInfo( "Piooooooh" );
		}

		public override void SetRespawn()
		{
			//transform.position = Vector3.left * 10f;
		}

		public override void Move( Vector3 dir )
		{
			transform.rotation = Quaternion.Lerp( transform.rotation, Quaternion.LookRotation(dir), moveSpeed * Time.deltaTime ); 
			transform.position  = transform.position + ( dir * moveSpeed * Time.deltaTime );
		}

		private Vector3 prePos = Vector3.zero;
		private void OnTriggerEnter( Collider coll )
		{
			Debug.Log( "Coll : " + coll.gameObject.name );

			var dir	= transform.position - coll.transform.position;
			dir.y		= 0f;
			dir.Normalize();
			prePos						= transform.position + (dir * coll.contactOffset );
			transform.position	= prePos;
		}

		private void OnTriggerStay( Collider coll )
		{
			transform.position = prePos;
		}

		private void OnTriggerExit( Collider coll )
		{
			transform.position = prePos;
		}
	}
}
