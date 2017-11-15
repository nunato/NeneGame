using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveManager : MonoBehaviour
{
	public float speed;
	public float jumpSpeed;

	private Rigidbody rbyPlayer;

	private bool fPlayerJump = true;

	void Start()
	{
		rbyPlayer = GetComponent<Rigidbody>();
	}

	void FixedUpdate()
	{
		Move();

		Jump();
	}

	private void Move()
	{
		float moveX = Input.GetAxis( "Horizontal");
		float moveZ = Input.GetAxis( "Vertical" );

		Vector3 cameraForward = Vector3.Scale( Camera.main.transform.forward, new Vector3(1, 0, 1)).normalized;

		Vector3 moveForward = cameraForward * moveZ + Camera.main.transform.right * moveX;

		rbyPlayer.velocity = moveForward * speed + new Vector3( 0, rbyPlayer.velocity.y, 0);

		if( moveForward != Vector3.zero ){
			transform.rotation = Quaternion.LookRotation( moveForward );
		}
	}

	private void Jump()
	{
		if( Input.GetKeyDown( KeyCode.Space ) && fPlayerJump == false ){
			rbyPlayer.velocity = new Vector3( 0, 1, 0 ) * jumpSpeed;
		}
	}

	void OnCollisionExit( Collision other )
	{
		if( other.gameObject.tag == "Ground" ){
			fPlayerJump = true;
		}
	}

	void OnCollisionEnter( Collision other )
	{
		if( other.gameObject.tag == "Ground" ){
			fPlayerJump = false;
		}
	}
}
