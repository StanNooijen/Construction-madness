using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    Rigidbody2D m_Rigidbody;
    float m_Speed;
    public float jumpAmount = 10;

    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody2D>();
        m_Speed = 10.0f;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            m_Rigidbody.velocity = transform.right * m_Speed;
        }

        if (Input.GetKey(KeyCode.A))
        {
            m_Rigidbody.velocity = -transform.right * m_Speed;
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            m_Rigidbody.AddForce(Vector2.up * jumpAmount, ForceMode2D.Impulse);
        }
    }
}
