using UnityEngine;
using System.Collections;

public class KooplaEnemy : MonoBehaviour {

    public int speed;
    bool isFacingLeft = true;
    Rigidbody2D rb;
    Animator anim;
    bool isAlive;

	// Use this for initialization
	void Start () {
        isAlive = true;

	    if(speed <= 0)
        {
            Debug.Log("Speed not set, setting to speed 1");
            speed = 1;
        }

        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

        // Check that a RB was added
        if (!rb)
        {
            //Add RB if not found
            rb = gameObject.AddComponent<Rigidbody2D>();
            Debug.Log("No RigidBody Detected, RigidBody Added");
        }

        if(!anim)
        {
            anim = gameObject.AddComponent<Animator>();
            Debug.Log("No Animator Detected, Animator Added");
        }
    }
	
	// Update is called once per frame
	void Update () {
        if (isAlive)
        {
            if (isFacingLeft)
            {
                rb.velocity = new Vector2(-speed, rb.velocity.y);
            }
            else
            {
                rb.velocity = new Vector2(speed, rb.velocity.y);
            }
        }
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "EnemyStopper" || coll.gameObject.tag == "Enemy")

        {
            flipCharacter();
        }
    }
    void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.gameObject.tag == "Player")
        {
            isAlive = false;
            anim.SetBool("isDead", true);
            gameObject.GetComponent<Rigidbody2D>().isKinematic = true;
            Invoke("kooplaDead", 2);
        }
    }
    void kooplaDead()
    {
        gameObject.GetComponent<EdgeCollider2D>().enabled = false;
        gameObject.GetComponent<BoxCollider2D>().enabled = false;

        Destroy(gameObject);
        GameManager.levelInstance.score += 100;
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
