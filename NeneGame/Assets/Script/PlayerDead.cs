using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDead : MonoBehaviour
{
	public int deadArea = -2;
	public GameObject playerDeadParticle;

	private Vector3 spownPoint;

	void Start()
	{
		spownPoint = transform.position;
	}

	void Update()
	{
		if( transform.position.y < deadArea ){
			Instantiate( playerDeadParticle, transform.position, Quaternion.identity );
			transform.position = spownPoint;
		}
	}
}
