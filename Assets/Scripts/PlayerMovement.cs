using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float playerSpeed = 3;
    public Transform player;
    public Quaternion rotation;
    public float ylock;

    void Start()
    {
        player = GetComponent<Transform>();
        ylock = player.position.y;
        rotation = player.rotation;
    }

    void MovePlayer()
    {
        float xMovement = Input.GetAxis("Horizontal") * Time.deltaTime;

        if (xMovement != 0)
        {
            player.position = new Vector2(player.position.x + xMovement * playerSpeed, ylock);
        }
    }

    void Update()
    {
        MovePlayer();
        player.rotation = rotation;
    }
}
