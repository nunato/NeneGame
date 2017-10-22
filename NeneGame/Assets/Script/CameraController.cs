using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
	public float cameraSpeed;
	private GameObject targetObj;
	private Vector3 targetPos;

	void Start()
	{
		targetObj = GameObject.Find("Player");
		targetPos = targetObj.transform.position;
	}

	void Update()
	{
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
