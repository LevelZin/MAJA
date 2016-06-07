using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
public class Movement : MonoBehaviour
{
    [SerializeField]
    private float Speed = 10;   // Characters move speed

    void FixedUpdate()
    {
        Vector3 input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));   // Button input
        GetComponent<Rigidbody>().MovePosition(transform.position + (input * Speed));  // Move in the selected direction

        if (input != Vector3.zero)  // If character has not moved
        {
            transform.rotation = Quaternion.LookRotation(input);    // rotate in direction pressed
        }
    }

}
