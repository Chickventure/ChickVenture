using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{
    // Start is called before the first frame update
    public int nilaiKoin;
    public Text textkoin;

    private void OnTriggerEnter2D(Collider2D collision)
    {

        void Start()
        {
            textkoin.text = "= " + nilaiKoin.ToString();
        }

        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Coin Diambil");
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "coin")
        {
            nilaiKoin += 1;
            textkoin.text = " " + nilaiKoin.ToString();

        }
  
        
    }

}
