using UnityEngine;
using UnityEngine.SceneManagement;

public class ItemShop : MonoBehaviour
{
    [SerializeField] GameObject itemShop;

    public void Shop()
    {
        itemShop.SetActive(true);
        Time.timeScale = 1;
    }
}
