using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public GameObject pointA;
    public GameObject pointB;
    public static float speed = 4;
    //private Rigidbody2D rigbod;
    private Animator anim;
    private Transform currentPoint;
    void Start()
    {
        //rigbod = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        currentPoint = pointB.transform;
        anim.SetBool("isMoving", true);
    }

    void FixedUpdate()
    {
        //Vector2 point = currentPoint.position - transform.position;
        if(currentPoint == pointB.transform)
        {
            //rigbod.velocity = new Vector2(speed, 0);
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
        else
        {
            //rigbod.velocity = new Vector2(-speed, 0);
            transform.Translate(Vector2.right * -speed * Time.deltaTime);
        }
        //Changed movement code so less physics code can be running.

        if (Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == pointB.transform)
        {
            flip();
            currentPoint = pointA.transform;
        }

        if (Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == pointA.transform)
        {
            flip();
            currentPoint = pointB.transform;
        }
    }

    private void flip()
    {
        Vector3 localScale = transform.localScale;
        localScale.x *= -1;
        transform.localScale = localScale;
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(pointA.transform.position, 0.5f);
        Gizmos.DrawWireSphere(pointB.transform.position, 0.5f);
    }
}
