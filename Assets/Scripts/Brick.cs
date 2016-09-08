using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {

    int brickValue = 50;
    public GameObject player;
    public AudioClip breakBrick;
    public AudioClip brickNotBreak;

    void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.gameObject.tag == "Player" && coll.GetComponentInParent<character>().isSuper == true)
        {
            SoundManager.instance.playSingleSound(breakBrick);
            Invoke("destroyIt", .1f);
        }
        else if(coll.gameObject.tag == "Player" && coll.GetComponentInParent<character>().isSuper == false)
        {
            SoundManager.instance.playSingleSound(brickNotBreak);
        }
    }

    void destroyIt()
    {
        GameManager.levelInstance.score += brickValue;
        Destroy(gameObject);
    }
}
