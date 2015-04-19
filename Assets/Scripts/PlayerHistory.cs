using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerHistory : MonoBehaviour {

	void Start () {
		transform.Find ("TotalCoin").GetComponent<Text>().text = 
			"You earned "+PlayerPrefs.GetInt("TotalCoin").ToString()+" coin.";
		transform.Find ("CorrectTyping").GetComponent<Text>().text = 
			PlayerPrefs.GetInt("CorrectTyping").ToString()+" correct type.";
		transform.Find ("WrongTyping").GetComponent<Text>().text = 
			PlayerPrefs.GetInt("WrongTyping").ToString()+" wrong type.";
		transform.Find ("FinalATK").GetComponent<Text>().text = 
			"You got "+PlayerPrefs.GetFloat("FinalATK").ToString()+" attack point.";
		transform.Find ("FinalSPD").GetComponent<Text>().text = 
			"You got "+PlayerPrefs.GetFloat("FinalSPD").ToString()+" speed point.";
	}	
}
