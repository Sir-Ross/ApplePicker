using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BasketMovement : MonoBehaviour {

    public void Quit() {
        Application.Quit();
    }

    [SerializeField]
    public int score = 0;
    public GameObject menu;
    public GameObject game;
    public int lives = 3;

    public Text text1;
    public Text text2;
    public Text text3;

    public void End() {
        if (score > Variables.highscore) {
            Variables.highscore = score;
        }
        Variables.score = score;
        score = 0;
        lives = 3;

        gameObject.transform.position = new Vector3(0.0f,-3.0f);
        GameObject.Find("tree").transform.position = new Vector3(0.0f, 2.0f);
        GameObject.Find("apple").transform.position = new Vector3(0.0f, 2.0f);

        menu.SetActive(true);
        game.SetActive(false);
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
        text3.text = Variables.highscore.ToString();

        if (Input.GetKey("right")) {
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(4.0f, 0.0f);
        } else if (Input.GetKey("left")){
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(-4.0f, 0.0f);
        } else{
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0.0f, 0.0f);
        }

    }
}
