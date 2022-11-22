using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    Rigidbody2D m_Rigidbody;
    float m_Speed;
    
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody2D>();
        m_Speed = 10.0f;
    }
    //test

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

        if (Input.GetKey(KeyCode.W))
        {
            transform.Rotate(new Vector3(0, 0, 1) * Time.deltaTime * m_Speed);
        }
    }
}
