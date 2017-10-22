using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveManager : MonoBehaviour
{
	public float speed;

	private float moveX,moveZ;
	private Rigidbody rbyPlayer;

	void Start()
	{
		rbyPlayer = GetComponent<Rigidbody>();
	}

	void Update () 
	{
		moveX = Input.GetAxis( "Horizontal");
		moveZ = Input.GetAxis( "Vertical" );
	}

	void FixedUpdate()
	{
		Vector3 cameraForward = Vector3.Scale( Camera.main.transform.forward, new Vector3(1, 0, 1)).normalized;

		Vector3 moveForward = cameraForward * moveZ + Camera.main.transform.right * moveX;

		rbyPlayer.velocity = moveForward * speed + new Vector3( 0, rbyPlayer.velocity.y, 0);

		if( moveForward != Vector3.zero ){
			transform.rotation = Quaternion.LookRotation( moveForward );
		}
	}
}
