using UnityEngine;
using System.Collections;

public class character : MonoBehaviour {

    public int highscore;

    Rigidbody2D rigidBody;

    // Character Stat Variables
    public float moveSpeed;
    public float originalMoveSpeed;
    public float runSpeed;
    public float jumpPower;

    // Character State Variables
    public bool isGrounded;
    public bool isRunning;
    public bool isWalking;
    public bool isFacingLeft;
    public bool isSuper = false;
    public bool isFlowerPower = false;
    public bool isDead = false;

    public LayerMask isGroundedLayer;
    public Transform groundCheck;

    Animator anim;


	// Use this for initialization
	void Start () {

        rigidBody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        isSuper = false;

        if (!anim)
            Debug.LogWarning("Animator not set");

        if (!rigidBody)
            Debug.LogWarning("RigidBody2D Not linked");

        if (moveSpeed <= 0f)
        {
            Debug.LogWarning("Speed Not Configured, Assigning MoveSpeed to 4");
            moveSpeed = 4f;
        }

        if (jumpPower <= 0f)
        {
            Debug.LogWarning("JumpPower Not Configured, Assigning JumpPower to 3");
            jumpPower = 3f;
        }

	}
	
	// Update is called once per frame
	void Update ()
    {
        float moveValue = Input.GetAxis("Horizontal");
        //float yVel = rigidBody.velocity.y;

        rigidBody.velocity = new Vector2(moveValue * moveSpeed, rigidBody.velocity.y);

        isGrounded = Physics2D.OverlapCircle(groundCheck.position, 0.1f, isGroundedLayer);
        //if (yVel == 0)
        //{
        //    isGrounded = true;
        //}
        //else
        //{
        //    isGrounded = false;
        //}

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rigidBody.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
            anim.SetBool("isGrounded", false);
        }
        else
        {
            anim.SetBool("isGrounded", true);
        }

        anim.SetFloat("Speed", Mathf.Abs(moveValue));

        if (moveValue > 0 && isFacingLeft)
        {
            flipCharacter();
        }
        else if (moveValue < 0 && !isFacingLeft)
        {
            flipCharacter();
        }

        if (groundCheck.transform.position.y <= -8f)
        {
            isDead = true;
        }

        //if (Input.GetButton("Fire3"))
        //{
        //    moveSpeed = runSpeed;
        //}
        //else if(!Input.GetButton("Fire3"))
        //{
        //    moveSpeed = originalMoveSpeed;
        //}

    }

    void IsMarioSuper()
    {
        if(isSuper == false)
        {

        }
        if(isSuper == true)
        {

        }
        if(isFlowerPower == true)
        {

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
