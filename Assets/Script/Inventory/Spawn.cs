using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject ItemPerfabs;
    public Transform player;
    public string itemName;
  
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

   public void SpawnDropItem()
    {
       Vector3 playerposition = new Vector3(player.position.x, player.position.y, player.position.z + 4);
        Instantiate(ItemPerfabs, playerposition, Quaternion.identity);
   }
}
