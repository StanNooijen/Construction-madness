using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToLevelTwo : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Level Switch");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
