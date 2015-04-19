using UnityEngine;
using System.Collections;

public class Level : MonoBehaviour {

	public static int nowLevel = 1;

	void Start () {
		nowLevel = 1;
	}
	
	void Next () {
		nowLevel ++;
	}
}
