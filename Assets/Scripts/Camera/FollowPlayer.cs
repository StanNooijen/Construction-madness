using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;

    void Update()
    {
        transform.position = new Vector3(offset.x, player.position.y + offset.y, offset.z = -10); // Camera follows the player with specified offset position
    }
}
