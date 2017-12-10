using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
	public float cameraSpeed;
	private GameObject targetObj;
	private Vector3 targetPos;

	private RespownManager respownManager;

	void Start()
	{
		targetObj = GameObject.Find("Player");
		targetPos = targetObj.transform.position;
		GameObject reManager = GameObject.Find("RespownManager");
		respownManager = reManager.gameObject.GetComponent<RespownManager>();
	}

	void Update()
	{
		if( respownManager.isPlayerDead == false ){
			transform.position += targetObj.transform.position - targetPos;
			targetPos = targetObj.transform.position;
		}
	}
}
