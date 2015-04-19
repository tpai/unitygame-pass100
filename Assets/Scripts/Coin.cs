using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Coin : MonoBehaviour {

	public int coin = 100;

	void Start () {

	}

	void Update () {
		GetComponent<Text> ().text = "COIN:" + coin;
	}

	void Add (int amt) {
		if (coin + amt > 999999) {
			coin = 999999;
		}
		else if (coin + amt < 0) {
			coin = 0;
		}
		else {
			coin += amt;
		}
	}
}
