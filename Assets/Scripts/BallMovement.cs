using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class BallMovement : MonoBehaviour
{

    [SerializeField] public float m_Speed;
    public Rigidbody m_Rigid;

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal"); // ����� �Է� ��Ʈ���� ����, ���� ������ �޾ƿ�
        float vertical = Input.GetAxis("Vertical");

        // x�� ����, z�� ������ �������� �� ����
        Vector3 movement = new Vector3(horizontal, 0, vertical);
        m_Rigid.AddForce(movement * m_Speed);
    }
}
