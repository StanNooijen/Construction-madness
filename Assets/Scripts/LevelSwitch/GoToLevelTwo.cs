using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToLevelTwo : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.LoadScene("Kevin Scene"); // change to level 2 eventually
    }
}
