using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Volume : MonoBehaviour {
    [SerializeField]
    public AudioSource MusicVolume;
    public AudioSource SFXVolume;

	// Use this for initialization
	void Start () {
        MusicVolume.volume = PlayerPrefs.GetFloat("mv");
        SFXVolume.volume = PlayerPrefs.GetFloat("sv");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
