using UnityEngine;
using System.Collections;

public class coinSpawn : MonoBehaviour {

    public GameObject player;
    int coinValue = 200;
    Rigidbody2D rb;

	// Use this for initialization
	void Start ()
    {
        Invoke("coinFunction", 1.4f);
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(transform.up * 8, ForceMode2D.Impulse);
    }
	
	// Update is called once per frame
	void Update () {


    }

    void coinFunction()
    {
        GameManager.levelInstance.score += coinValue;
        GameManager.levelInstance.coins += 1;
        Destroy(gameObject);
    }
}
