
using UnityEngine;

public class HealthEnemy : MonoBehaviour
{
    [SerializeField]
    private float StarttingHealht;
    public float currentHealth { get; private set; }
    private Animator anim;

    private void Awake()
    {
        currentHealth = StarttingHealht;
        anim = GetComponent<Animator>();
    }

    public void TakeDamage(float damage)
    {
        currentHealth = Mathf.Clamp(currentHealth - damage, 0, StarttingHealht);
        if (currentHealth > 0)
        {
            anim.SetTrigger("enemy");
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
