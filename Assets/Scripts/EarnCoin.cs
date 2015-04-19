using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EarnCoin : MonoBehaviour {

	int answer = 0;

	void Start () {
		RandomNumber ();
	}

	void Update () {
		if (
			(Input.GetKeyDown(KeyCode.Alpha0) && answer == 0) || 
		    (Input.GetKeyDown(KeyCode.Alpha1) && answer == 1) ||
		    (Input.GetKeyDown(KeyCode.Alpha2) && answer == 2) ||
			(Input.GetKeyDown(KeyCode.Alpha3) && answer == 3) ||
		    (Input.GetKeyDown(KeyCode.Alpha4) && answer == 4) ||
		    (Input.GetKeyDown(KeyCode.Alpha5) && answer == 5) ||
		    (Input.GetKeyDown(KeyCode.Alpha6) && answer == 6) ||
		    (Input.GetKeyDown(KeyCode.Alpha7) && answer == 7) ||
		    (Input.GetKeyDown(KeyCode.Alpha8) && answer == 8) ||
		    (Input.GetKeyDown(KeyCode.Alpha9) && answer == 9)
		) {
			Coin.Add (1);
			RandomNumber ();
		}
	}
	
	void RandomNumber () {
		answer = Random.Range (0, 10);
		GetComponent<Text>().text = answer.ToString();
	}
}
