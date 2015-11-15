using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
	public static GameManager gm;

	private GameObject currentFactCanvas = null;

	// Use this for initialization
	void Start () {
		// get a reference to the GameManager component for use by other scripts
		if (gm == null) 
			gm = this.gameObject.GetComponent<GameManager>();
	}

	public void SetCanvas(GameObject newFactCanvas) {
		if (currentFactCanvas) {
			currentFactCanvas.SetActive (false);
		}

		currentFactCanvas = newFactCanvas;
		currentFactCanvas.SetActive(true);
	}

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
