using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
	private static int GameScore = 0;
	private static RespownManager respownManager;

	public static int gameScore
	{
		get { return GameScore; }
	}

	void Start ()
	{
		GameScore = 0;
		GameObject reManager = GameObject.Find("RespownManager");
		respownManager = reManager.gameObject.GetComponent<RespownManager>();
	}

	public static void AddScore( int newScore )
	{
		if( respownManager.isPlayerDead == false ){
			GameScore += newScore;
		}
	}
}
