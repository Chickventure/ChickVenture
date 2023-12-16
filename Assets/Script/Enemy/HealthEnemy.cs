using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthEnemy : MonoBehaviour
{
    [SerializeField]
    private float StarttinghealhtEnemy;
    public float currentHealth { get; private set; }

    private void Awake()
    {
        currentHealth = StarttinghealhtEnemy;
    }

    public void TakeDamage(float damage)
    {
        currentHealth = Mathf.Clamp(currentHealth - damage, 0, StarttinghealhtEnemy);
        if (currentHealth < 0)
        {
            Destroy(gameObject);
        }
    }
}
