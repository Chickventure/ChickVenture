using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject PointA;
    public GameObject PointB;
    private Rigidbody2D rb;
    private Animator anim;
    private Transform currentPoint;
    public float speed;

    // Start is called before the first frame update
    //void Start()
    //{
    //    rb = GetComponent<Rigidbody2D>();
    //    anim = GetComponent<Animator>();
    //    currentPoint = PointB.transform;
    //    anim.SetBool("isRunning", false);
    //}

    // Update is called once per frame
    void Update()
    {
        //Vector2 point = currentPoint.position - transform.position;
        //if (currentPoint == PointB.transform)
        //{
        //    rb.velocity = new Vector3(0, speed, 0);
        //}
        //else
        //{
        //    rb.velocity = new Vector3(0, -speed, 0);
        //}

        //if (Vector3.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == PointB.transform)
        //{
        //    flip();
        //    currentPoint = PointB.transform;
        //}
        //if (Vector3.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == PointA.transform)
        //{
        //    flip();
        //    currentPoint = PointA.transform;
        //}
    }

    private void flip()
    {
        Vector3 LocalScale = transform.localScale;
        LocalScale.y *= -1;
        transform.localScale = LocalScale;
    }

    //private void OnDrawGizmos()
    //{
    //    Gizmos.DrawWireSphere(PointA.transform.position, 0.5f);
    //    Gizmos.DrawWireSphere(PointB.transform.position, 0.5f);
    //    Gizmos.DrawLine(PointA.transform.position, PointB.transform.position);
    //}
}
