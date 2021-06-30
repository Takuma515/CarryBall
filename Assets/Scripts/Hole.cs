using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hole : MonoBehaviour
{
    public string targetTag;
    bool isHolding;
    AudioSource goalSound;

    void Start()
    {
        goalSound = GetComponent<AudioSource>();
    }

    // ボールが入っているかを返す
    public bool IsHolding()
    {
        return isHolding;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == targetTag)
        {
            isHolding = true;
            goalSound.Play();
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == targetTag)
        {
            isHolding = false;
        }
    }

    void OnTriggerStay(Collider other)
    {
        Rigidbody r = other.gameObject.GetComponent<Rigidbody>();

        // ボールの方向の計算
        Vector3 direction = other.gameObject.transform.position - transform.position;
        direction.Normalize();

        // タグに応じてボールに力を加える
        if (other.gameObject.tag == targetTag)
        {
            r.velocity *= 0.9f;
            r.AddForce(direction * -20.0f, ForceMode.Acceleration);
        }
        else
        {
            r.AddForce(direction * 80.0f, ForceMode.Acceleration);
        }
    }
}
