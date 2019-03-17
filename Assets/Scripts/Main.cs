using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour {
    public bool a = false;

	// Use this for initialization
	void Start () {
        GameObject.Find("Game").SetActive(false);
        GameObject.Find("Menu").SetActive(true);
    }
	
	// Update is called once per frame
	void Update () {
        if (a) {
            GameObject.Find("Menu").SetActive(false);
            GameObject.Find("Game").SetActive(true);
        }
	}
}
