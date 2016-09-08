using UnityEngine;
using System.Collections;

public class IGCoin : MonoBehaviour {

    int coinValue = 200;
    public AudioClip coinClip;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter2D(Collision2D coll)
    {
        if(coll.gameObject.tag == "Player")
        {
            SoundManager.instance.playSingleSound(coinClip);
            GameManager.levelInstance.score += coinValue;
            GameManager.levelInstance.coins += 1;
            Destroy(gameObject);
        }
    }
}
