using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowButton : MonoBehaviour
{
	private PlayerMoveManager PlayerMove;
	private bool IsPress = false;
	private float arrowValue = 0;

	void Start()
	{
		GameObject Player = GameObject.Find("Player");
		PlayerMove = Player.GetComponent<PlayerMoveManager>();
	}

	public void OnPushDown( float Side )
	{
		Debug.Log( "Side" + Side );
		PlayerMove.IsMovePlayer( true );
		IsPress = true;
		arrowValue = Side;
	}
	public void OnPudhUp()
	{
		Debug.Log( "OnPudhUp" );
		PlayerMove.IsMovePlayer( false );
		IsPress = false;
	}

	void Update()
	{
		if( IsPress ){
			Move( arrowValue );
		}
		else{
			Move( 0 );
		}
	}

	private void Move( float Side )
	{
		Debug.Log( "MoveSide" + Side );
		PlayerMove.PlayerMove( Side );
	}
}
