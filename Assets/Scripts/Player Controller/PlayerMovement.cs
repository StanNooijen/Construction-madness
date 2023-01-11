using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D m_Rigidbody;
    float speed = 10f;
    public int jumpcount = 0;
    public float jumpHeight = 20f;
    public Animator animator;

    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody2D>();
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
            animator.SetBool("RunRight", true);
        }
        else
        {
            animator.SetBool("RunRight", false);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-transform.right * speed * Time.deltaTime);
            animator.SetBool("RunLeft", true);
        }
        else
        {
            animator.SetBool("RunLeft", false);
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
