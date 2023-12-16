using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coin : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
      

        //coin
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



        // item peanuts
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("peanuts Diambil");
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "Peanuts")
        {
            PlayerController.instance1.nilaiPeanuts += 1;
            PlayerController.instance1.TextPeanuts.text = " " + PlayerController.instance1.nilaiPeanuts.ToString();
            PlayerPrefs.SetInt("Peanuts", PlayerController.instance1.nilaiPeanuts);
        }

        //ITEM PERANGKAP
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("perangkap Diambil");
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "Perangkap")
        {
            PlayerController.instance2.nilaiPerangkap += 1;
            PlayerController.instance2.TextPerangkap.text = " " + PlayerController.instance2.nilaiPerangkap.ToString();
            PlayerPrefs.SetInt("Perangkap", PlayerController.instance2.nilaiPerangkap);
        }

        //ITEM JAGUNG
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("jagung Diambil");
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "Jagung")
        {
            PlayerController.instance3.nilaiJagung += 1;
            PlayerController.instance3.TextJagung.text = " " + PlayerController.instance3.nilaiJagung.ToString();
            PlayerPrefs.SetInt("Jagung", PlayerController.instance3.nilaiJagung);
        }
    }
}

