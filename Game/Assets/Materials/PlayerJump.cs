using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    public float speed = 10f;
    public Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    

    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {   if (Input.GetButtonUp("Jump"))
        {
            rb.AddForce(new Vector3(0, 5, 0), ForceMode.Impulse);
        }        
    }
}
