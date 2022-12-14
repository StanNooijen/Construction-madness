using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    BoxCollider2D Ground;
    Rigidbody2D m_Rigidbody;
    float speed = 10f;
    public int jumpcount = 0;
    public float jumpHeight = 20f;

    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody2D>();
        Ground = GetComponent<BoxCollider2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            Debug.Log("Floor");
            jumpcount = 0;
        }
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(transform.right * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-transform.right * speed * Time.deltaTime);
        }
        
        if (Input.GetButtonDown("Jump"))
        {
            if (jumpcount == 0)
            {
                m_Rigidbody.AddForce(Vector2.up * jumpHeight, ForceMode2D.Impulse);
                jumpcount++;
            }
        }
    }
}
