using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveManager : MonoBehaviour
{
	public float speed;

	private Rigidbody rbyPlayer;
	private float playerVelocity = 0;
	private bool IsMove = false;

	void Start()
	{
		rbyPlayer = GetComponent<Rigidbody>();
	}

	void FixedUpdate()
	{
		if( IsMove == true ){
			rbyPlayer.velocity = new Vector3( 0, 0, playerVelocity * speed * Time.deltaTime );
		}
		else{
			rbyPlayer.velocity = new Vector3( 0, rbyPlayer.velocity.y, 0 );
		}
	}

	public void PlayerMove( float velocity )
	{
		playerVelocity = velocity;
	}

	public void IsMovePlayer( bool ArrowDown )
	{
		IsMove = ArrowDown;
	}
}
