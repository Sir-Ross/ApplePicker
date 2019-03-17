using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleMovement : MonoBehaviour {
    [SerializeField]
    public GameObject basket;
    public GameObject tree;
    //public BasketMovement basketScript;
    public GameObject apple;

    

    void End() {
        //tree.GetComponent<TreeMovement>().SpawnApple();
        //tree.GetComponent<TreeMovement>().toggle();
        Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.tag == "Basket") {
            //Destroy(this);
            basket.GetComponent<BasketMovement>().increment();
            Destroy(apple);
        }
    }

    // Use this for initialization
    void Start () {
        basket = GameObject.Find("Basket");
        apple = GameObject.Find("apple(Clone)");
    }
	
	// Update is called once per frame
	void Update () {
        
        if (gameObject.transform.position.y < -5) {
            basket.GetComponent<BasketMovement>().damage();
            End();
        }
	}
}
