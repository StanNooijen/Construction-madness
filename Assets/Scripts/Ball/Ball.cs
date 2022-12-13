using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour
{

    Rigidbody2D rb;
    public float force = 15f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = Vector2.one * force;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene("Kevin Scene");
            Debug.Log("Scene switches");
        }

        if (collision.gameObject.CompareTag("WallRight"))
        {
            force = -10f;
            rb.velocity = Vector2.left * force;
        }

        if (collision.gameObject.CompareTag("WallLeft"))
        {
            force = 10f;
            rb.velocity = Vector2.right * force;
        }

    }
}
