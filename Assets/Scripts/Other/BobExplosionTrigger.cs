using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BobExplosionTrigger : MonoBehaviour
{
    public GameObject bob;
    public Animator animator;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            animator.SetBool("BobExplode", true);
            StartCoroutine(BobIsExploding());
        }
    }

    private IEnumerator BobIsExploding()
    {
        yield return new WaitForSeconds(2);
        Destroy(bob);
    }

}
