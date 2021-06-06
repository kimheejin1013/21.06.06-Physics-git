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
        float horizontal = Input.GetAxis("Horizontal"); // 사용자 입력 컨트롤의 수평, 수직 각도를 받아옴
        float vertical = Input.GetAxis("Vertical");

        // x는 수평, z는 수직을 기준으로 축 생성
        Vector3 movement = new Vector3(horizontal, 0, vertical);
        m_Rigid.AddForce(movement * m_Speed);
    }
}
