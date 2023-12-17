using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    private InventoyController inventory;
    public GameObject itemButton;
    public string itemName;

    void Start()
    {
        inventory = FindObjectOfType<InventoyController>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            for (int i = 0; i < inventory.Slots.Length; i++)
            {
                if (inventory.isFull[i] == true && inventory.Slots[i].transform.GetComponent<Slot>().amount < 10)
                {
                    if (itemName == inventory.Slots[i].transform.GetComponentInChildren<Spawn>().itemName)
                    {
                        Destroy(gameObject);
                        inventory.Slots[i].GetComponent<Slot>().amount += 1;
                        break;
                    }
                }
                else if (inventory.isFull[i] == false)
                {
                    inventory.isFull[i] = true;
                    Instantiate(itemButton, inventory.Slots[i].transform, false);
                    inventory.Slots[i].GetComponent<Slot>().amount += 1;
                    Destroy(gameObject);
                    break;
                }

            }
        }
 
    }
    
}




    
