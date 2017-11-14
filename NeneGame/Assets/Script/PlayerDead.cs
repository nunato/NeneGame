using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* プレイヤーの死亡判定クラス */
/* 条件 */
/* エリア外への移動 */
/* エネミーとの接触 */
public class PlayerDead : MonoBehaviour
{
	public int deadArea = -2;
	public GameObject playerDeadParticle;

	private Vector3 spownPoint;

	void Start()
	{
		spownPoint = transform.position;
	}

	void Update()
	{
		if( transform.position.y < deadArea ){
			respawnPlayer( );
		}
	}

	void OnCollisionEnter( Collision other )
	{
		if( other.gameObject.tag == "Enemy" ){
			respawnPlayer( );
		}
	}

	private void respawnPlayer( )
	{
		Instantiate( playerDeadParticle, transform.position, Quaternion.identity );
		transform.position = spownPoint;
	}
}
