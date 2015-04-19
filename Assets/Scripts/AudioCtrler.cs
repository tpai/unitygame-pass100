using UnityEngine;
using System.Collections;

public class AudioCtrler : MonoBehaviour {

	public AudioClip[] audioClips;
	AudioSource audioSource;

	void Start () {
		audioSource = GetComponent<AudioSource>();
	}

	void Play (int id) {
		audioSource.clip = audioClips[id];
		audioSource.Play ();
	}
}
