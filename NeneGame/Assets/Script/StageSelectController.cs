using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*************************************************
ゲーム画面への遷移とゲームの終了ボタンを管理するファイル
**************************************************/
public class StageSelectController : MonoBehaviour
{
	public void OnClickStart( )
	{
		SceneManager.LoadScene("NeneGameStage4");
	}
	public void OnClickExit()
	{
#if UNITY_EDITOR
		UnityEditor.EditorApplication.isPlaying = false;
#else
		Application.Quit();
#endif
	}
}
