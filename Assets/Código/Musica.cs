using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Musica : MonoBehaviour {

	public AudioClip MusicClip;

	public AudioSource MusicSource;

	void start(){
		MusicSource.clip = MusicClip;
	}

	void Update(){
		if (Input.GetKeyDown (KeyCode.M)) {
			MusicSource.Pause ();
		if(Input.GetKeyDown (KeyCode.V)){
				MusicSource.Play();
			}
		}
	}
}
