
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
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

    private void Start()
    {
        if (SceneManager.GetActiveScene().name == "Level 1")
        {
            Resetsave();
        }
    }

        public void Resetsave()
    {
        PlayerPrefs.DeleteAll();
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
