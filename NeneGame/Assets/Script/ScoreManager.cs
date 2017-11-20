using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
	private static int GameScore;

	void Start ()
	{
		GameScore = 0;
	}

	public static void AddScore( int newScore )
	{
		GameScore += newScore;
	}

	public static int GetScore()
	{
		return GameScore;
	}
}
