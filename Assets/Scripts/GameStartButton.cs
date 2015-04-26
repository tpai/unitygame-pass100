using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameStartButton : MonoBehaviour {

	public Animator maskAnim;

	public void ShowMask () {
		transform.Find ("Text").GetComponent<Text>().enabled = false;
		maskAnim.SetBool ("show", true);
		Invoke ("GoToGamePlay", 1.5f);
	}

	public void GoToGamePlay () {
		Application.LoadLevel ("GamePlay");
	}
}
