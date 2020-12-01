using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    [SerializeField] private Player player;

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            player.Move();
        }
        if (Input.GetMouseButtonUp(0))
        {
            player.Stop();
        }
    }
}
