using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    Rigidbody rb;
    float jumpForce = 200.0f;

    void Start()
    {
        this.rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // スマホ用
        if (Input.GetMouseButtonDown(0) && this.rb.velocity.y == 0)
        {
            this.rb.AddForce(transform.up * this.jumpForce, ForceMode.Impulse);
        }

        // PC用
        if (Input.GetKeyDown(KeyCode.Space) && this.rb.velocity.y == 0)
        {
            this.rb.AddForce(transform.up * this.jumpForce, ForceMode.Impulse);
        }
    }
}
