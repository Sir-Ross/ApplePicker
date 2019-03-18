using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class Settings : MonoBehaviour {

    [SerializeField]
        public Slider MusicVolume;
    [SerializeField]
        public Slider SFXVolume;


	// Use this for initialization
	void Start () {
        //DontDestroyOnLoad(this.gameObject);
        if(MusicVolume)MusicVolume.value = (PlayerPrefs.GetFloat("mv"));
        if(SFXVolume)SFXVolume.value = (PlayerPrefs.GetFloat("sv"));
    }
	
	// Update is called once per frame
	void Update () {
        if(MusicVolume)PlayerPrefs.SetFloat("mv", MusicVolume.value);
        if(SFXVolume)PlayerPrefs.SetFloat("sv", SFXVolume.value);
    }

    public void loadGame() {
        SceneManager.LoadScene(0);
        SceneManager.UnloadScene(1);
        SceneManager.UnloadScene(2);
        SceneManager.UnloadScene(3);
    }

    public void loadMenu() {
        SceneManager.LoadScene(1);
        SceneManager.UnloadScene(0);
        SceneManager.UnloadScene(2);
        SceneManager.UnloadScene(3);
    }

    public void loadSettings() {
        SceneManager.LoadScene(2);
        SceneManager.UnloadScene(1);
        SceneManager.UnloadScene(0);
        SceneManager.UnloadScene(3);
    }

    public void loadEnd() {
        SceneManager.LoadScene(3);
        SceneManager.UnloadScene(1);
        SceneManager.UnloadScene(0);
        SceneManager.UnloadScene(2);
    }


}
