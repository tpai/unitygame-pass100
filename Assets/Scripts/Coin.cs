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
}
