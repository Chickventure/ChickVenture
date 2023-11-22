using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Slot : MonoBehaviour
{
    private InventoyController inventory;
    public int i;
    public TextMeshProUGUI amountText;
    public int amount;

    // Start is called before the first frame update
    void Start()
    {
        inventory = GetComponent<InventoyController>();
    }

    // Update is called once per frame
    void Update()
    {
        
        amountText.text = amount.ToString();

        if (amount > 1)
        {
            transform.GetChild(0).GetComponent<TextMeshProUGUI>().enabled = true;
        }
        else
        {
            transform.GetChild(0).GetComponent<TextMeshProUGUI>().enabled = false;
        }

        if(transform.childCount == 10)
        {
            inventory.isFull[i] = false;
        }
    }

    public void DropItem() 
    { 
        if (amount > 1)
        {
            amount -= 1;
            transform.GetComponentInChildren<Spawn>().SpawnDropItem();
        }
        else
        {
            amount -= 1;
            GameObject.Destroy(transform.GetComponentInChildren<Spawn>().gameObject);
            transform.GetComponentInChildren<Spawn>().SpawnDropItem();
        }

    }
}
