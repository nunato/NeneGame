using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
	public float cameraSpeed;
	private GameObject targetObj;
	private Vector3 targetPos;

	private RespownManager respownManager;
	private Vector3 respoenPoint;

	void Start()
	{
		targetObj = GameObject.Find("Player");
		targetPos = targetObj.transform.position;
		GameObject reManager = GameObject.Find("RespownManager");
		respownManager = reManager.gameObject.GetComponent<RespownManager>();
		respoenPoint = transform.position;
	}

	void Update()
	{
		if( respownManager.isPlayerDead == false && respownManager.isPlayerReswoning == false ){
			transform.position += targetObj.transform.position - targetPos;
			targetPos = targetObj.transform.position;

			if( Input.GetMouseButton(1)){
				float mouseInputX = Input.GetAxis( "Mouse X");
				float mouseInputY = Input.GetAxis( "Mouse Y" );

				transform.RotateAround( targetPos, Vector3.up, mouseInputX * Time.deltaTime * cameraSpeed );
				transform.RotateAround( targetPos, transform.right, mouseInputY * Time.deltaTime * cameraSpeed);
			}
		}
	}

	public void RestartCameraContlloer( GameObject player )
	{
		targetObj = player;
		targetPos = targetObj.transform.position;
		transform.position = respoenPoint;
	}
}
