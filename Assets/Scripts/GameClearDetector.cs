using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameClearDetector : MonoBehaviour
{
    public Hole holeRed;

    void OnGUI()
    {
        // ボールが入ったらラベルを表示
        if (holeRed.IsHolding())
        {
            GUI.matrix = Matrix4x4.Scale(Vector3.one * 2);
            GUI.Label(new Rect(50, 50, 100, 30), "Game Clear!!");
        }
    }
}
