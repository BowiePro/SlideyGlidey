
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // calls the player rigidbody
    public Rigidbody rb;

    // forward and sideways force
    public float frontForce = 200f;
    public float sideForce = 500f;

    // Update is called once per frame (fix with deltatime)
    void FixedUpdate() 
    {
        // add the forward force
        rb.AddForce(0, 0, frontForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sideForce * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sideForce * Time.deltaTime, 0, 0);
        }
    }
}
