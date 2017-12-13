using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RespownManager : MonoBehaviour
{
	public GameObject deadText;
	public GameObject SceneButtonController;

	private bool IsPlayerDead;
	private GameObject player;

	public bool isPlayerDead
	{
		get{ return IsPlayerDead; }
		set{ IsPlayerDead = value; }
	}

	void Start()
	{
		IsPlayerDead = false;
	}

	void Update()
	{
		if( Input.GetKeyDown( KeyCode.R ) && IsPlayerDead == true ){
			SceneManager.LoadScene("NenegameStage4");
			deadText.SetActive(false);
			IsPlayerDead = false;
			SceneButtonController.SetActive(false);
		}
	}

	public void ShowDeadText()
	{
		deadText.SetActive(true);
		SceneButtonController.SetActive(true);
	}
}
