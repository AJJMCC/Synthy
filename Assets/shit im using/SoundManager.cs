using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

    public AudioSource audio;
    public AudioClip[] music;
	// Use this for initialization
	void Start () {
        PlayNextSong();

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void PlayNextSong()
    {
        audio.clip = music[Random.Range(0, music.Length)];
        audio.Play();
        Invoke("PlayNextSong", audio.clip.length);
    }
}
