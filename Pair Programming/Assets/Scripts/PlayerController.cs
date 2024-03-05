using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    public float jumpPower;
    public float castDistance;
    public Vector2 boxSize;
    public LayerMask groundLayer;

    private float Move;
    private bool isFacingRight;
    private Rigidbody2D rigbod;
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        isFacingRight = true;
        anim = GetComponent<Animator>();
        rigbod = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    { 
        Move = Input.GetAxisRaw("Horizontal");

        rigbod.velocity = new Vector2(Move * moveSpeed, rigbod.velocity.y);

        if (Input.GetButtonDown("Jump") && isGrounded())
        {
            rigbod.AddForce(new Vector2(rigbod.velocity.x, jumpPower * 10));
        }

        if(Move != 0)
        {
            anim.SetBool("isMoving", true);
        }
        else
        {
            anim.SetBool("isMoving", false);
        }

        if(!isFacingRight && Move > 0)
        {
            Flip();
        }
        else if (isFacingRight && Move < 0)
        {
            Flip();
        }  
    }

    public void Flip()
    {
        isFacingRight = !isFacingRight;
        Vector3 localScale = transform.localScale;
        localScale.x *= -1f;
        transform.localScale = localScale;
    }
    public bool isGrounded()
    {
        if (Physics2D.BoxCast(transform.position, boxSize, 0, -transform.up, castDistance, groundLayer))
        {
            return true;
        }
        else 
        { 
            return false; 
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireCube(transform.position - transform.up * castDistance, boxSize);
    }
}
