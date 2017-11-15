using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSpownManager : MonoBehaviour
{
	public GameObject wallObject;
	public Transform spown;

	// Use this for initialization
	void Start ()
	{
		Instantiate( wallObject, spown.position, Quaternion.identity );
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}
}
