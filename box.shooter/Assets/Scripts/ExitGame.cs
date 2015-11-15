using UnityEngine;
using System.Collections;

public class ExitGame : MonoBehaviour {
	
	void OnCollisionEnter(Collision newCollision)
	{
		// only do stuff if hit by a projectile
		if (newCollision.gameObject.tag == "Projectile") {
			// call the RestartGame function in the game manager
			GameManager.gm.QuitGame();
		}
	}
}
