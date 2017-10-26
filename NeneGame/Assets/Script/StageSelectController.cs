﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageSelectController : MonoBehaviour
{
	public void OnClick( string sceneName )
	{
		if( sceneName != null ){
			SceneManager.LoadScene(sceneName);
		}
	}
}
