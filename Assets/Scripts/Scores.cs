using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scores : MonoBehaviour {
    [SerializeField]
    public Text[] scores;
	// Use this for initialization
	void Start () {
        scores[0].text = (PlayerPrefs.GetInt("s0").ToString());
        scores[1].text = (PlayerPrefs.GetInt("s1").ToString());
        scores[2].text = (PlayerPrefs.GetInt("s2").ToString());
        scores[3].text = (PlayerPrefs.GetInt("s3").ToString());
        scores[4].text = (PlayerPrefs.GetInt("s4").ToString());
        scores[5].text = (PlayerPrefs.GetInt("s5").ToString());
        scores[6].text = (PlayerPrefs.GetInt("s6").ToString());
        scores[7].text = (PlayerPrefs.GetInt("s7").ToString());
        scores[8].text = (PlayerPrefs.GetInt("s8").ToString());
        scores[9].text = (PlayerPrefs.GetInt("s9").ToString());
        scores[10].text = (PlayerPrefs.GetInt("s10").ToString());
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
