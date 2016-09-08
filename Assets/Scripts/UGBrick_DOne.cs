using UnityEngine;
using System.Collections;

public class UGBrick_DOne : MonoBehaviour {

    public AudioClip bumpBrick;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnColiisionEnter2D(Collision2D coll)
    {
        if(coll.gameObject.tag == "Player")
        {
            SoundManager.instance.playSingleSound(bumpBrick);
        }
    }
}
