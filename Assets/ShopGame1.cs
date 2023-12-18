using UnityEngine;
using UnityEngine.SceneManagement;

public class ItemShop : MonoBehaviour
{
    public string itemShopSceneName = "ItemShop";

    private bool isInItemShop = false;

    private void Update()
    {
        if (isInItemShop && Input.GetKeyDown(KeyCode.I))
        {
            SceneManager.LoadScene(itemShopSceneName);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("ItemShop"))
        {
            isInItemShop = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("ItemShop"))
        {
            isInItemShop = false;
        }
    }
}
