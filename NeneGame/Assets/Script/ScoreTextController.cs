using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTextController : MonoBehaviour
{
	public Text ScoreText;

	void Start ()
	{
		ScoreText.text = "Score: " + ScoreManager.gameScore;
	}

	void Update ()
	{
		ScoreText.text = "Score: " + ScoreManager.gameScore;
	}
}
