using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform player;

    void Update()
    {
        transform.position = new Vector3(player.position.x + 15, transform.position.y, player.position.z + 15);
        transform.LookAt(player.position);
    }
}
