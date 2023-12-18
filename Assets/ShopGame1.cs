using UnityEngine;
using UnityEngine.SceneManagement;

public class ItemShopOpener : MonoBehaviour
{
    [SerializeField] GameObject itemShop;

    public void OpenItemShop()
    {
        itemShop.SetActive(true);

    }
}

