using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float MovementSpeed;
    public float RotationSpeed;

    // Start is called before the first frame update
    void Start()
    {
        MovementSpeed = 0.1f;
        RotationSpeed = 2.5f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0, 0, MovementSpeed);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position += new Vector3(0, 0, -MovementSpeed);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-MovementSpeed, 0, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(MovementSpeed, 0, 0);
        }

        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(0, -RotationSpeed, 0);
        }

        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(0, RotationSpeed, 0);
        }
    }
}
