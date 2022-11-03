using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour
{

    public float speed;

    // Update is called once per frame
    void Update()
    {

        float xDirection = Input.GetAxis("Horizontal");

        // setting move direction
        Vector3 moveDirection = new Vector3(xDirection, 0.0f, 0.0f);

        transform.position += moveDirection * speed;
    }
}
