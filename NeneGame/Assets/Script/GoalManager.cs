using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalManager : MonoBehaviour
{
	public GameObject clearText;

	void OnTriggerEnter( Collider cllider )
	{
		if( cllider.CompareTag( "Player" ) ){
			clearText.SetActive(true);
			Destroy(gameObject);
		}
	}
}
