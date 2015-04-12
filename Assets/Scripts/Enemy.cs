using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	Animator anim;

	void Start () {
		anim = GetComponent<Animator> ();

		InvokeRepeating ("Attack", 0f, 1f);
	}
	
	void Attack () {
		anim.SetTrigger ("attack");
	}
}
