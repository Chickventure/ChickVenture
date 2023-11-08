using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator myAnim;

    [SerializeField]
    private int MoveSpeed;



    // Start is called before the first frame update
    void Start()
    {   
        //Memanggil Controler
        rb = GetComponent<Rigidbody2D>();
        //Memanggil Animasi Gerak
        myAnim = GetComponent<Animator>();
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
