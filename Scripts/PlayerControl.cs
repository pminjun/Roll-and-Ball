using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    [SerializeField]
    Vector3 v3Force;
    [SerializeField]
    KeyCode keyPosi;
    [SerializeField]
    KeyCode keyNega;

    Rigidbody rigdbody;

    public float jumpPower = 5f;
    int jumpCount;
    bool isGround;
    private void Start()
    {
        rigdbody = GetComponent<Rigidbody>();
        jumpCount = 1;
        isGround = true;
    }

    private void FixedUpdate()
    {
        Debug.Log(isGround);
        if (Input.GetKey(keyPosi))
        {
            GetComponent<Rigidbody>().velocity += v3Force;
        }
        if (Input.GetKey(keyNega))
        {
            GetComponent<Rigidbody>().velocity -= v3Force;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            if (isGround)
            {
                jumpCount = 1;
                if (Input.GetKey(KeyCode.Space))
                {
                    if (jumpCount == 1)
                    {
                        rigdbody.AddForce(0, 150f, 0);
                        isGround = false;
                        jumpCount = 0;
                    }
                }
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "ground")
        {
            isGround = true;
            jumpCount = 1;
        }
    }
}
