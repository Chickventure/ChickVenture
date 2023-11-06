using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Jagung : MonoBehaviour
{
    public int nilaiJagung;
    public Text textJagung;

    void Start()
    {
        textJagung.text = "= " + nilaiJagung.ToString();
    }

    if (collision.gameObject.tag == "Player"){
                    Destroy(gameObject);
}
}
