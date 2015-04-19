using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Coin : MonoBehaviour {

	public static int coin;
	public static int totalCoin;

	void Start () {
		coin = 0;
		totalCoin = 0;
	}

	void Update () {
		GetComponent<Text> ().text = "COIN:" + coin;
	}

	public static void Add (int amt) {
		if (coin + amt > 999999) {
			coin = 999999;
		}
		else if (coin + amt < 0) {
			coin = 0;
		}
		else {
			coin += amt;

			if (amt > 0)totalCoin += amt;
		}
	}
}
