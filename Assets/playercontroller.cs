using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
	void Start ()
    {
		
	}

	void Update ()
    {
        Contro();
	}
    void Contro()
    {
        float h = 2.0f * Input.GetAxis("Horizontal")*Time.deltaTime;
        float v = 2.0f * Input.GetAxis("Vertical")*Time.deltaTime;
        transform.Translate(h, 0, 0);
        transform.Translate(0, 0, v);
    }
}
