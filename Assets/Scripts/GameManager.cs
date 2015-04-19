using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public GameObject[] enemies;

	void Start () {

		SpawnEnemy ();

		StartCoroutine("LetsBattle");

		InvokeRepeating ("IfExistGoToNextLevel", 1f, 1f);
	}

	void IfExistGoToNextLevel () {
		if (DetectEnemyExist () == false) {
			// next level
			Debug.Log ("Go To Next Level!");
		}
	}

	bool DetectEnemyExist () {
		if (GameObject.Find ("Enemy") == null)return false;
		else return true;
	}

	IEnumerator LetsBattle () {
		yield return new WaitForSeconds (.5f);
		GameObject.Find ("Player").SendMessage ("Battle");
		yield return new WaitForSeconds (.8f);
		GameObject.Find ("Enemy").SendMessage ("Battle");
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
