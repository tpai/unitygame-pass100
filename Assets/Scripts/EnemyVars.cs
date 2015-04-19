using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EnemyVars : MonoBehaviour {

	bool isBinded = false;
	float hp, atk, spd;
	Character enemy;

	void Bind () {
		isBinded = true;
		enemy = GameObject.Find ("Enemy").GetComponent<Character> ();
	}
	
	void Update () {
		if (isBinded) {
			hp = enemy.hp;
			atk = enemy.atk;
			spd = enemy.spd;

			transform.Find ("HP").GetComponent<Text> ().text = "HP:"+hp.ToString("F0");
			transform.Find ("ATK").GetComponent<Text> ().text = "ATK:"+atk.ToString("F0");
			transform.Find ("SPD").GetComponent<Text> ().text = "SPD:"+spd.ToString("F2");
		}
	}
}
