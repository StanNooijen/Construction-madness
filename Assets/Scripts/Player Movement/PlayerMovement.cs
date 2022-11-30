using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    Rigidbody2D m_Rigidbody;
    float speed = 10f;
    public float jumpAmount = 0;
    public float jumpHeight = 10f;

    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Floor"))
        {
            Debug.Log("floor");
            jumpAmount = 0;
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

        if (jumpAmount == 0)
        {
            if (Input.GetButtonDown("Jump"))
            {
                m_Rigidbody.AddForce(Vector2.up * jumpHeight, ForceMode2D.Impulse);
                jumpAmount++;
            }
        }
    }
}
