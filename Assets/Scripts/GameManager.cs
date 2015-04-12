using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public GameObject[] enemies;

	void Start () {

		SpawnEnemy ();

		LetsBattle ();
	}

	void Update () {

	}

	void LetsBattle () {
		GameObject.Find ("Enemy").SendMessage ("Battle");
		GameObject.Find ("Player").SendMessage ("Battle");
	}
	
	GameObject SpawnEnemy () {
		GameObject obj = (GameObject)Instantiate (
			enemies [Random.Range (0, 2)],
			new Vector2 (2, 0),
			Quaternion.identity
		);
		obj.name = "Enemy";
		return obj;
	}
}
