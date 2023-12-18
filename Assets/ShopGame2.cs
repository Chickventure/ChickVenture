using UnityEngine;
using UnityEngine.SceneManagement;

public class ItemShopCloser : MonoBehaviour
{
    [SerializeField] GameObject itemShop;

    public void CloseItemShop()
    {
        itemShop.SetActive(false);

    }
}

