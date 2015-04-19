using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EarnCoin : MonoBehaviour {

	int answer = 0;
	public static int correctTyping;
	public static int wrongTyping;

	void Start () {
		correctTyping = 0;
		wrongTyping = 0;
		RandomNumber ();
	}

	void Update () {
//		if (
//			(Input.GetKeyDown(KeyCode.Alpha0) && answer == 0) || 
//		    (Input.GetKeyDown(KeyCode.Alpha1) && answer == 1) ||
//		    (Input.GetKeyDown(KeyCode.Alpha2) && answer == 2) ||
//			(Input.GetKeyDown(KeyCode.Alpha3) && answer == 3) ||
//		    (Input.GetKeyDown(KeyCode.Alpha4) && answer == 4) ||
//		    (Input.GetKeyDown(KeyCode.Alpha5) && answer == 5) ||
//		    (Input.GetKeyDown(KeyCode.Alpha6) && answer == 6) ||
//		    (Input.GetKeyDown(KeyCode.Alpha7) && answer == 7) ||
//		    (Input.GetKeyDown(KeyCode.Alpha8) && answer == 8) ||
//		    (Input.GetKeyDown(KeyCode.Alpha9) && answer == 9)
//		) {
//			Coin.Add (1);
//			RandomNumber ();
//		}
	}

	void OnGUI () {
		Event e = Event.current;
		if (e.type == EventType.KeyDown)
		{
			int key = (int)e.keyCode - (int)KeyCode.Keypad0;
			if (key == answer) {
				Coin.Add (1000);
				correctTyping ++;
				RandomNumber ();
			}
			else {
				wrongTyping ++;
				Coin.Add (1);
			}
			Event.current.Use();
		}
	}

	void RandomNumber () {
		answer = Random.Range (0, 10);
		GetComponent<Text>().text = answer.ToString();
	}
}
