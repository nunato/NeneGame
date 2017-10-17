using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
	public Transform PlayerTransform;

	private Vector3 offset;

	void Start()
	{
		offset = transform.position - PlayerTransform.position;
	}

	void Update()
	{
		transform.position = PlayerTransform.position + offset;
	}
}
