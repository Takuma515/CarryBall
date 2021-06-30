using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    Rigidbody rb;
    AudioSource jumpSound;
    float jumpForce = 200.0f;
    Vector3 up = new Vector3(0, 1, 0);

    void Start()
    {
        this.rb = GetComponent<Rigidbody>();
        this.jumpSound = GetComponent<AudioSource>();
    }

    void Update()
    {

        // スマホ用
        if (Application.isMobilePlatform)
        {
            if (Input.GetMouseButtonDown(0) && this.rb.velocity.y == 0)
            {
                this.rb.AddForce(transform.up * this.jumpForce, ForceMode.Impulse);
            }

        }
        // PC用
        if (Input.GetKeyDown(KeyCode.Space) && this.rb.velocity.y == 0)
        {
            this.rb.AddForce(up * this.jumpForce, ForceMode.Impulse);
            this.jumpSound.Play();
        }
    }
}
