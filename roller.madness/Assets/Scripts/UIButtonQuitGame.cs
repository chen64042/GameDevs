using UnityEngine;
using System.Collections;


public class UIButtonQuitGame : MonoBehaviour {

	private string quitGameURL = "https://www.coursera.org/learn/game-development";
	
	public void QuitGame()
	{
		#if UNITY_EDITOR
		UnityEditor.EditorApplication.isPlaying = false;
		#elif UNITY_WEBPLAYER
		Application.OpenURL(quitGameURL);
		#else
		Application.Quit();
		#endif

		Object[] objects = GameObject.FindObjectsOfType<GameObject>();

		foreach(GameObject o in objects) {
			Destroy(o);
		}
	}
}