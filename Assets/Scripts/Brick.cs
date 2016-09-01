using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {

    int brickValue = 50;
    public GameObject player;

    void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.gameObject.tag == "Player" && coll.GetComponentInParent<character>().isSuper == true)
        {
            Invoke("destroyIt", .1f);
        }
    }

    void destroyIt()
    {
        GameManager.levelInstance.score += brickValue;
        Destroy(gameObject);
    }
}
