using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BasketMovement : MonoBehaviour {

    public void Quit() {
        Application.Quit();
    }

    [SerializeField]
    public int score = 0;
    //public GameObject menu;
    public GameObject basket;
    public int lives = 3;

    public Text text1;
    public Text text2;
    //public Text text3;

    public void End() {
        /*if (score > Variables.highscore) {
            Variables.highscore = score;
        }*/
        Variables.score = score;
        scoreRecord(score);
        score = 0;
        lives = 3;

        basket.transform.position = new Vector3(0.0f,-3.0f);
        GameObject.Find("tree").transform.position = new Vector3(0.0f, 2.0f);
        GameObject.Find("apple").transform.position = new Vector3(0.0f, 2.0f);

        //menu.SetActive(true);
        //game.SetActive(false);
        

        SceneManager.LoadScene(3);
        SceneManager.UnloadScene(0);
    }

    public void scoreRecord(int s) {
        PlayerPrefs.SetInt("s0", s);
        int[] scores = new int[10];
        scores[0] = PlayerPrefs.GetInt("s1"); scores[1] = PlayerPrefs.GetInt("s2"); scores[2] = PlayerPrefs.GetInt("s3");
        scores[3] = PlayerPrefs.GetInt("s4"); scores[4] = PlayerPrefs.GetInt("s5"); scores[5] = PlayerPrefs.GetInt("s6");
        scores[6] = PlayerPrefs.GetInt("s7"); scores[7] = PlayerPrefs.GetInt("s8"); scores[8] = PlayerPrefs.GetInt("s9");
        scores[9] = PlayerPrefs.GetInt("s10");

        for(int i = 0; i < 10; i++) {
            if (s > scores[i]) {
                for(int j = i; j < 9; j++) {
                    scores[j + 1] = scores[j];
                }
                scores[i] = s;
                break;
            }
        }

        PlayerPrefs.SetInt("s1", scores[0]); PlayerPrefs.SetInt("s2", scores[1]); PlayerPrefs.SetInt("s3", scores[2]);
        PlayerPrefs.SetInt("s4", scores[3]); PlayerPrefs.SetInt("s5", scores[4]); PlayerPrefs.SetInt("s6", scores[5]);
        PlayerPrefs.SetInt("s7", scores[6]); PlayerPrefs.SetInt("s8", scores[7]); PlayerPrefs.SetInt("s9", scores[8]);
        PlayerPrefs.SetInt("s10", scores[9]);

    }

    public void increment() {
        score++;
    }

    public void damage() {
        if (lives > 1) lives--;
        else End();
    }

    // Use this for initialization
    void Start () {
        lives = 3;
        score = 0;
	}
	
	// Update is called once per frame
	void Update () {

        text1.text = lives.ToString();
        text2.text = score.ToString();
        //text3.text = Variables.highscore.ToString();

        if (Input.GetKey("right")) {
            basket.GetComponent<Rigidbody2D>().velocity = new Vector2(4.0f, 0.0f);
        } else if (Input.GetKey("left")){
            basket.GetComponent<Rigidbody2D>().velocity = new Vector2(-4.0f, 0.0f);
        } else{
            basket.GetComponent<Rigidbody2D>().velocity = new Vector2(0.0f, 0.0f);
        }

    }
}
