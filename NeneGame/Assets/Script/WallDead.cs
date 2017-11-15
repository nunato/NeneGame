using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallDead : MonoBehaviour
{
	private float deadArea = -10;

	void Update()
	{
		if( transform.position.x < deadArea ){
			Destroy( gameObject );
		}
	}
}
