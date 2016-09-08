using UnityEngine;
using System.Collections;

public class KooplaEnemy : MonoBehaviour {

    public int speed;
    bool isFacingLeft = true;
    Rigidbody2D rb;

	// Use this for initialization
	void Start () {
	    if(speed <= 0)
        {
            Debug.Log("Speed not set, setting to speed 1");
            speed = 1;
        }

        rb = GetComponent<Rigidbody2D>();

        // Check that a RB was added
        if (!rb)
        {
            //Add RB if not found
            rb = gameObject.AddComponent<Rigidbody2D>();

        }
    }
	
	// Update is called once per frame
	void Update () {
        if (isFacingLeft)
        {
            rb.velocity = new Vector2(-speed, rb.velocity.y);
        }
        else
        {
            rb.velocity = new Vector2(speed, rb.velocity.y);
        }
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "EnemyStopper" || coll.gameObject.tag == "Enemy")

        {
            flipCharacter();
        }
    }

    void flipCharacter()
    {
        isFacingLeft = !isFacingLeft;


        // Make a copy of old scale
        Vector3 scaleFactor = transform.localScale;

        //Flip scale of x
        scaleFactor.x *= -1;

        // Update scale to new flipped scale
        transform.localScale = scaleFactor;
    }
}
