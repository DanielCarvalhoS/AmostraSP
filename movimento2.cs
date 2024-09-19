using System.Collections;

using System.Collections.Generic;

using UnityEngine;


//coloca o script mo carro


public class movimento2 : MonoBehaviour
{
    Vector3 m;
    // Start is called before the first frame update
    void Start()
    {

        transform.position = m;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {

                m.x = 0.03f;
                transform.Translate(m);

        }
        if (Input.GetKey(KeyCode.A))
        {

                m.x = -0.03f;
                transform.Translate(m);

        }
        if (Input.GetKey(KeyCode.W))
        {           
                m.z = 0.03f;
                transform.Translate(m);
        }
        if (Input.GetKey(KeyCode.S))
        {
                m.z = -0.03f;
                transform.Translate(m);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            m.x = 0;
            transform.Translate(m);
            transform.Rotate(0f, 5f, 0f);
        }
        if (Input.GetKey(KeyCode.E))
        {
            m.x = 0;
            transform.Translate(m);
            transform.Rotate(0f, -5f, 0f);
        }
        m.Set(0, 0, 0);
    }
}