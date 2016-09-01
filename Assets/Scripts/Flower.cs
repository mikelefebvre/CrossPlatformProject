using UnityEngine;
using System.Collections;

public class Flower : MonoBehaviour {

    public GameObject player;
    int flowerValue = 1000;
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
            if(coll.gameObject.GetComponent<character>().isSuper == false)
            {
                coll.gameObject.GetComponent<character>().isSuper = true;
                coll.gameObject.GetComponent<Animator>().SetBool("IsSuper", true);
                GameManager.levelInstance.score += flowerValue;
                Destroy(gameObject);
            }
            else
            {
                coll.gameObject.GetComponent<character>().isFlowerPower = true;
                GameManager.levelInstance.score += flowerValue;
                Destroy(gameObject);
            }
        }
    }
}
