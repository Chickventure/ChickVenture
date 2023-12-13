using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator myAnim;

    [SerializeField]
    private int MoveSpeed;

    //COIN DAN ITEM
    public int nilaiKoin, nilaiPeanuts, nilaiPerangkap, nilaiJagung;
    public Text textkoin, TextPeanuts, TextPerangkap, TextJagung;
    public static PlayerController instance, instance1, instance2, instance3;
    
    private void Awake()
    {
        instance = this; 
        instance1 = this;
        instance2 = this;
        instance3 = this;
    }


    // Start is called before the first frame update
    void Start()
    {   
        //Memanggil Controler
        rb = GetComponent<Rigidbody2D>();
        //Memanggil Animasi Gerak
        myAnim = GetComponent<Animator>();

        //coin
        nilaiKoin = PlayerPrefs.GetInt("coin");
        textkoin.text = " " + nilaiKoin.ToString();

        Debug.Log(nilaiKoin);

        //item Peanuts
        nilaiPeanuts = PlayerPrefs.GetInt("Peanuts");
        TextPeanuts.text = "" + nilaiPeanuts.ToString();

        //ITEM PERANGKAP
        nilaiPerangkap = PlayerPrefs.GetInt("Perangkap");
        TextPerangkap.text = "" + nilaiPerangkap.ToString();

        //ITEM JAGUNG
        nilaiJagung = PlayerPrefs.GetInt("Jagung");
        TextJagung.text = "" + nilaiJagung.ToString();

        //save scene
        if (SceneManager.GetActiveScene().name == "Main Menu")
        {
            Resetsave();
        }
    }

    public void Resetsave()
    {
        PlayerPrefs.DeleteAll();
    }
    // Update is called once per frame
    void Update()
    {
        //CONTROLER
        rb.velocity = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")) * MoveSpeed * 5 * Time.deltaTime;

        //SETING ANIMASI KANAN KIRI
        myAnim.SetFloat("MoveX", rb.velocity.x);
        myAnim.SetFloat("MoveY", rb.velocity.y);


        //IdleAnimation
        if (Input.GetAxisRaw("Horizontal") == 1 || Input.GetAxisRaw("Horizontal") == -1 || Input.GetAxisRaw("Vertical") == 1 || Input.GetAxisRaw("Vertical") == -1)
        {
            myAnim.SetFloat("LastMoveX", Input.GetAxisRaw("Horizontal"));
            myAnim.SetFloat("LastMoveY", Input.GetAxisRaw("Vertical"));
        }

    }


}
