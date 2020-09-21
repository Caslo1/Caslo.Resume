using System;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 12f;
    public float gravity = -9.81f;
    public float jumpHeight = 3f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    Vector3 velocity;
    bool isGrounded;

    public static Dictionary<Tuple<int, int>, Quaternion> rotationDictionary = new Dictionary<Tuple<int, int>, Quaternion>
        {
            { new Tuple<int, int>(1, 0), Quaternion.Euler(0f, 0f, 0f)},
            { new Tuple<int, int>(-1, 0), Quaternion.Euler(0f, 180f, 0f)},
            { new Tuple<int, int>(0, 1), Quaternion.Euler(0f, -90f, 0f)},
            { new Tuple<int, int>(0, -1), Quaternion.Euler(0f, 90f, 0f)},
            { new Tuple<int, int>(1, -1), Quaternion.Euler(0f, 45f, 0f)},
            { new Tuple<int, int>(1, 1), Quaternion.Euler(0f, -45f, 0f)},
            { new Tuple<int, int>(-1, -1), Quaternion.Euler(0f, 135f, 0f)},
            { new Tuple<int, int>(-1, 1), Quaternion.Euler(0f, -135f, 0f)},
            { new Tuple<int, int>(0, 0), Quaternion.Euler(0f, 0f, 0f)}

        };

    void Update()
    {

        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }


        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        //Debug.Log(x.ToString() + ' ' + z.ToString() );


        velocity.x = x * speed;
        velocity.z = z * speed;



        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);

        transform.rotation = rotationDictionary[new Tuple<int, int>(Math.Sign(x), Math.Sign(z))];
    }
}