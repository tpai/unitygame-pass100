using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerVars : MonoBehaviour {

	float hp, atk, spd;
	Character player;

	void Start () {
		player = GameObject.Find ("Player").GetComponent<Character> ();
	}
	
	void Update () {
		hp = player.hp;
		atk = player.atk;
		spd = player.spd;

		transform.Find ("HP").GetComponent<Text> ().text = "HP:"+hp.ToString("F0");
		transform.Find ("ATK").GetComponent<Text> ().text = "ATK:"+atk.ToString("F0");
		transform.Find ("SPD").GetComponent<Text> ().text = "SPD:"+spd.ToString("F2");
	}
}
