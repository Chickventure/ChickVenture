using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Health playerHealth;
    [SerializeField] private Image totalhealthBar;
    [SerializeField] private Image currenthealthBar;

    private void Start()
    {
        totalhealthBar.fillAmount = playerHealth.currentHealth / 3;

        if (SceneManager.GetActiveScene().name == "Level 1")
        {
            Resetsave();
        }
    }      

    

    public void Resetsave()
    {
    PlayerPrefs.DeleteAll();
    }

private void Update()
    {
        currenthealthBar.fillAmount = playerHealth.currentHealth / 3;
    }
}
