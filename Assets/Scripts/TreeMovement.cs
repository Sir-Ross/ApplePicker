using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TreeMovement : MonoBehaviour {

    public bool a = false;
    public bool direction = false;

    public void flip() {
        if (Random.Range(0,100) ==1) {
            direction = !direction;
        }
    }

    public void SpawnApple() {
        Instantiate(GameObject.Find("apple"),GameObject.Find("tree").transform.position, GameObject.Find("tree").transform.rotation);
        GameObject.Find("apple(Clone)").GetComponent<Rigidbody2D>().simulated = true;
        GameObject.Find("apple(Clone)").GetComponent<Rigidbody2D>().WakeUp();
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (!GameObject.Find("apple(Clone)")) SpawnApple();
        flip();

        if (gameObject.transform.position.x > 7 || gameObject.transform.position.x < -7) {
            direction = !direction;
        }

        if (direction) {
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(3.0f, 0.0f);
        } else {
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(-3.0f, 0.0f); 
        }

        
    }
}
