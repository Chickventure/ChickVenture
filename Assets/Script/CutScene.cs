using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutScene : MonoBehaviour
{
    public float wait_time = 5f;

    private void Start()
    {
        StartCoroutine(wait_for_intro());
    }

    IEnumerator wait_for_intro()
    {
        yield return new WaitForSeconds(wait_time);

        SceneManager.LoadScene("Level 1");
    }
}

