using System;
using System.Collections.Generic;
using System.Linq;

using UnityEngine;

public class RotateCube : MonoBehaviour
{
    public float m_Speed = 10.0f;
    public Vector3 m_Axis = Vector3.zero;

    private void Update()
    {
        transform.RotateAround(transform.localPosition, m_Axis, m_Speed);
    }

    //private void OnCollisionEnter(Collision collision)
    //{
    //    Destroy(gameObject);
    //}  
    
    private void OnTriggerEnter(Collider other)
    {
        GameObject go = GameObject.Find("Score Text");
        ScoreModule module = go.GetComponent<ScoreModule>();
        module.AddCount(); // ScoreModule.AddCount() 함수 호출!

        Destroy(gameObject);
    }
}

