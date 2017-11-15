using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSpownManager : MonoBehaviour
{
	public GameObject wallObject;
	public Transform spown;

	void Start ()
	{
		Instantiate( wallObject, spown.position, Quaternion.identity );
	}
}
