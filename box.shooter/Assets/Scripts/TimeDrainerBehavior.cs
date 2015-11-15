using UnityEngine;
using System.Collections;

public class TimeDrainerBehavior : TargetBehavior {	
	public float countDown = 10.0f;
	private float currentTime;
	// explosion when hit?

	// Use this for initialization
	void Start () {
		if (gameObject.GetComponentInChildren<TextMesh>() == null) {
			throw new MissingReferenceException("No countDownText specified !");
		}

		currentTime = countDown;
	}
	
	// Update is called once per frame
	void Update ()
	{
		currentTime -= Time.deltaTime;

		if (currentTime < 0) {
			GameManager.gm.DrainTime (countDown);
			Destroy (gameObject);
			return ;
		} else {
			gameObject.GetComponentInChildren<TextMesh>().text = currentTime.ToString("0.00");
		}
	}	
}
