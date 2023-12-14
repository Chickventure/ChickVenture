using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_sideaway : MonoBehaviour
{
    [SerializeField] private float moveDistance;
    [SerializeField] private float speed;
    [SerializeField] private float damage;
    private bool movingUp;
    private float upEdge;
    private float downEdge;


    private void Awake()
    {
        upEdge = transform.position.y - moveDistance;
        downEdge = transform.position.y + moveDistance;
    }

    public void Update()
    {
        if (movingUp)
        {
            if(transform.position.y > upEdge)
            {
                transform.position = new Vector3(transform.position.x , transform.position.y - speed * Time.deltaTime, transform.position.z);
                
            }
            else
            {
                movingUp = false;
            }
        }
        else
        {
            if (transform.position.y < downEdge)
            {

                transform.position = new Vector3(transform.position.x , transform.position.y + speed * Time.deltaTime, transform.position.z);
                
            }
            else
            {
                movingUp = true;
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player") 
        {
            collision.GetComponent<Health>().TakeDamage(damage);
        }
    }

}
