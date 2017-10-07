using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveManager : MonoBehaviour
{
	public float speed;

	private Rigidbody rbyPlayer;

	void Start()
	{
		rbyPlayer = GetComponent<Rigidbody>();
	}

	void Update () 
	{
		float moveX = Input.GetAxis( "Horizontal");
		float moveZ = Input.GetAxis( "Vertical" );

		rbyPlayer.AddForce( moveX * speed, 0, moveZ * speed );
	}
}
