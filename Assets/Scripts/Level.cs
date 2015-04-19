using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Level : MonoBehaviour {

	public static int nowLevel;

	void Start () {
		nowLevel = 1;
	}

	void FixedUpdate () {
		GetComponent<Text>().text = "Level: "+nowLevel.ToString();
	}
	
	public static void Next () {
		nowLevel ++;
	}
}
