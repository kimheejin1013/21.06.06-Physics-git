using System.Collections;
using UnityEngine;


    public class PinCheck : MonoBehaviour
    {

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

    private void OnCollisionEnter(Collision collision)
    {
        if(transform.position.y < -10.0f)
        {
            GameObject go = GameObject.Find("Score Text");
            ScoreModule module = go.GetComponent<ScoreModule>();
            module.AddCount();

            Destroy(gameObject);
        }
    }

    }
