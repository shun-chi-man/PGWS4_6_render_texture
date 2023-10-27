using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereBehaviourScript2 : MonoBehaviour
{
    // �~�̔��a
    public float radius = 10f;

    // �����ʒu�̕ێ��p
    Vector3 initPos;
    // Start is called before the first frame update
    void Start()
    {
        // �����ʒu�̕ێ�
        initPos = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        CalcPosition();
    }

    // ���̈ʒu���v�Z���郁�\�b�h
    void CalcPosition()
    {
        // �ʑ��̌v�Z
        float phase = Time.time * Mathf.PI;

        // ���݈ʒu�̌v�Z
        float yPos = radius * Mathf.Cos(phase);
        float xPos = radius * Mathf.Sin(phase);

        // �I�u�W�F�N�g�̈ʒu��ݒ肷��
        Vector3 pos = new Vector3(xPos, yPos, initPos.z);
        gameObject.transform.position = pos;
    }
}
