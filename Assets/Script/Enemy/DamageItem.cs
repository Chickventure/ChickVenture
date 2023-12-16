using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageItem : MonoBehaviour
{
    [SerializeField] private float damage;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Peanuts")
        {
            collision.GetComponent<HealthEnemy>().TakeDamage(damage);
        }
    }
}
