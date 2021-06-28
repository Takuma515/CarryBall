using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityController : MonoBehaviour
{
    // 重力加速度
    const float Gravity = 9.81f;

    // 重力のスケール
    public float gravityScale = 1.0f;

    void Update()
    {
        Vector3 vector = new Vector3();

        // モバイル端末の場合
        if (Application.isMobilePlatform)
        {
            vector.x = Input.acceleration.x;
            vector.z = Input.acceleration.y;

            // 画面をタップしたとき
            if (Input.GetMouseButtonDown(0)) 
            {
                vector.y = 5.0f; 
            }
            else
            {
                vector.y = -1.0f;
            }
        }
        else
        {
            // キーの入力を検知し、ベクトルを設定
            vector.x = Input.GetAxis("Horizontal");
            vector.z = Input.GetAxis("Vertical");

            // 高さ方向の判定はスペースキー
            if (Input.GetKey(KeyCode.Space))
            {
                vector.y = 5.0f;
            }
            else
            {
                vector.y = -1.0f;
            }
        }

        // 重力を入力に合わせて変化させる
        Physics.gravity = Gravity * vector.normalized * gravityScale;
    }
}
