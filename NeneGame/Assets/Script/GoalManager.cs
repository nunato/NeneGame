using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalManager : MonoBehaviour
{
	void OnTriggerEnter( Collider cllider )
	{
		if( cllider.CompareTag( "Player" ) ){
			Destroy( gameObject );
		}
	}
}
