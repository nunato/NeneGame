using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTextController : MonoBehaviour
{
	public Text ScoreText;

	void Start ()
	{
		ScoreText.text = "Score: 0";
	}

	void Update ()
	{
		ScoreText.text = "Score: " + ScoreManager.GetScore();
	}
}
