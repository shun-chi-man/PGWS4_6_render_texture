using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereBehaviourScript2 : MonoBehaviour
{
    // 円の半径
    public float radius = 10f;

    // 初期位置の保持用
    Vector3 initPos;
    // Start is called before the first frame update
    void Start()
    {
        // 初期位置の保持
        initPos = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        CalcPosition();
    }

    // 球の位置を計算するメソッド
    void CalcPosition()
    {
        // 位相の計算
        float phase = Time.time * Mathf.PI;

        // 現在位置の計算
        float yPos = radius * Mathf.Cos(phase);
        float xPos = radius * Mathf.Sin(phase);

        // オブジェクトの位置を設定する
        Vector3 pos = new Vector3(xPos, yPos, initPos.z);
        gameObject.transform.position = pos;
    }
}
