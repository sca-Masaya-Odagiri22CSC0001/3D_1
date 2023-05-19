using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 20; // ��������

    private Rigidbody rb; // Rididbody

    void Start()
    {
        // Rigidbody ���擾
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // �J�[�\���L�[�̓��͂��擾
        var moveHorizontal = Input.GetAxis("Horizontal");
        var moveVertical = Input.GetAxis("Vertical");

        // �J�[�\���L�[�̓��͂ɍ��킹�Ĉړ�������ݒ�
        var movement = new Vector3(moveHorizontal, 0, moveVertical);

        // Ridigbody �ɗ͂�^���ċʂ𓮂���
        rb.AddForce(movement * speed);
    }
}
