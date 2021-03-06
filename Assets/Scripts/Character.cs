﻿using UnityEngine;
using System.Collections;

public class Character : MonoBehaviour {

	public bool isEnemy = false;
	public float hp;
	public float maxHP = 100f;
	public float atk = 1f;
	public float spd = 1f;

	Character target;
	Animator anim;

	void Start () {
		hp = maxHP;
		anim = GetComponent<Animator> ();
	}

	void Bind () {
		StartCoroutine ("FindTarget");
	}

	IEnumerator FindTarget () {
		yield return new WaitForSeconds (.5f);
		if (isEnemy)
			target = GameObject.Find ("Player").GetComponent<Character> ();
		else
			target = GameObject.Find ("Enemy").GetComponent<Character> ();
	}

	void Battle () {
		InvokeRepeating ("Attack", .1f, 1f/spd);
	}

	void StopBattle () {
		CancelInvoke ("Attack");
	}

	void Attack () {
		anim.SetTrigger ("attack");
		if (target != null) {
			target.AddHP (-atk);
		}
	}

	void Hit () {
		anim.SetTrigger ("hit");
	}

	public void AddHP (float amt) {
		if (hp + amt > maxHP) {
			hp = maxHP;
		}
		else if(hp + amt < 0) {
			hp = 0;
			StopBattle ();
			target.SendMessage("StopBattle");
			if (transform.name == "Enemy") {
				Coin.Add (Level.nowLevel * 1000);
			}
			else if(transform.name == "Player") {
				PlayerPrefs.SetFloat("FinalATK", atk);
				PlayerPrefs.SetFloat("FinalSPD", spd);
			}
			Destroy (gameObject);
		}
		else {
			// under attack
			if(amt < 0) {
				Hit ();
			}

			hp += amt;
		}
	}

	public void AddATK (float amt) {
		atk += amt;
	}

	public void AddSPD (float amt) {
		spd += amt;
	}
}
