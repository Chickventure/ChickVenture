using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{
    // Start is called before the first frame update
    

    private void OnTriggerEnter2D(Collider2D collision)
    {

       

        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Coin Diambil");
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "coin")
        {
            PlayerController.instance.nilaiKoin += 1;
            PlayerController.instance.textkoin.text = " " + PlayerController.instance.nilaiKoin.ToString();
            PlayerPrefs.SetInt("coin", PlayerController.instance.nilaiKoin);
        }
  
        
    }

}
