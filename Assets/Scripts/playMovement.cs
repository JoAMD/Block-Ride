using UnityEngine;

public class playMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = -1000f;
    public float sideForce = -700f;
    public Transform player;
    public float initDistance;

    // Start is called before the first frame update
    void Start()
    {
        initDistance = player.position.z;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //if(-player.position.z + initDistance <= 200f)
        //{
            rb.AddForce(0, 0, forwardForce * Time.deltaTime, ForceMode.VelocityChange);
        //}

        if (Input.GetKey("d"))
        {
            rb.AddForce(sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        else if (Input.GetKey("a"))
        {
            rb.AddForce(-sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        else if (Input.GetKey("w"))
        {
            rb.AddForce(0, -sideForce * Time.deltaTime, 0, ForceMode.VelocityChange);
        }
        else if (Input.GetKey("s"))
        {
            rb.AddForce(0, sideForce * Time.deltaTime, 0, ForceMode.VelocityChange);
        }
    }
}
