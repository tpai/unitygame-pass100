using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EarnCoin : MonoBehaviour {

	int answer = 0;
	
	void Start () {
		InvokeRepeating ("RandomNumber", .1f, 1f);
	}
	
	void RandomNumber () {
		GetComponent<Text>().text = Random.Range (0, 10).ToString();
	}
}
