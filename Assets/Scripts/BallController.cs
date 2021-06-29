using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    Rigidbody rb;
    float jumpForce = 300.0f;

    void Start()
    {
        this.rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // ジャンプする
        if (Input.GetKeyDown(KeyCode.Space) && this.rb.velocity.y == 0)
        {
            this.rb.AddForce(transform.up * this.jumpForce, ForceMode.Impulse);
        }
    }
}
