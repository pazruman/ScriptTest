using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        // 配列を初期化する
        int[] points = { 1, 2, 3, 4, 5};

        // 配列の要素数のぶんだけ処理を繰り返す
        for (int i = 0; i < points.Length; i++)
        {
            // 配列の要素が0以上の場合
            if (points[i] >= 0)
            {
                // 配列の要素を表示する
                Debug.Log(points[i]);
            }
        }

        // 配列の要素数のぶんだけ処理を繰り返す
        for (int k = points.Length - 1; k >= 0; k--)
        {
            // 配列の要素が0以上の場合
            if (points[k] >= 0)
            {
                // 配列の要素を表示する
                Debug.Log(points[k]);
            }

        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}