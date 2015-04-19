using UnityEngine;
using System.Collections;

public class Buff : MonoBehaviour {

	Coin coin;
	Character player;

	public int hpInput = 5;
	public int atkInput = 1;
	public float spdInput = 1;

	public int hpCost = 5;
	public int atkCost = 10;
	public int spdCost = 15;

	void Start () {
		player = GameObject.Find ("Player").GetComponent<Character> ();
	}

	public void AddHP () {
		if (Coin.coin - hpCost >= 0) {
			// add hp
			player.AddHP (hpInput);
			Coin.coin -= hpCost;
		}
	}

	public void AddATK () {
		if (Coin.coin - atkCost >= 0) {
			// add atk
			player.AddATK(atkInput);
			Coin.coin -= atkCost;
		}
	}

	public void AddSPD () {
		if (Coin.coin - spdCost >= 0) {
			// add spd
			player.AddSPD(spdInput);
			Coin.coin -= spdCost;
		}
	}
}
