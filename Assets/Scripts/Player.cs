using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public float hp;
	public float maxHP = 100f;
	public float atk = 1f;
	public float spd = 1f;

	void Start () {
		hp = maxHP;
	}

	void AddHP (float amt) {
		if (hp + amt > maxHP) {
			hp = maxHP;
		}
		else if(hp + amt < 0) {
			hp = 0;
		}
		else {
			hp += amt;
		}
	}

	void AddATK (float amt) {
		atk += amt;
	}

	void AddSPD (float amt) {
		spd += amt;
	}
}
