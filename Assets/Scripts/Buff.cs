using UnityEngine;
using System.Collections;

public class Buff : MonoBehaviour {

	Coin coin;
	Player player;

	public int hpInput = 5;
	public int atkInput = 1;
	public int spdInput = 1;

	public int hpCost = 5;
	public int atkCost = 10;
	public int spdCost = 15;

	void Start () {
		coin = GameObject.Find ("Coin").GetComponent<Coin> ();
		player = GameObject.Find ("Player").GetComponent<Player> ();
	}

	public void AddHP () {
		if (coin.coin - hpCost >= 0 && player.hp + hpInput <= player.maxHP) {
			// add hp
			player.AddHP (hpInput);
			coin.coin -= hpCost;
		}
	}

	public void AddATK () {
		if (coin.coin - atkCost >= 0) {
			// add atk
			player.AddATK(atkInput);
			coin.coin -= atkCost;
		}
	}

	public void AddSPD () {
		if (coin.coin - spdCost >= 0) {
			// add spd
			player.AddSPD(spdInput);
			coin.coin -= spdCost;
		}
	}
}
