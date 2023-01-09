
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    public Rigidbody rb;

    public float fowardForce = 150f;
    public float sidewaysForce = 500f;
    // Start is called before the first frame update


    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, fowardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
        }








    }

    void FixedUpdate2()
    {
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 500 * Time.deltaTime, 0);
        }

    }
}
    