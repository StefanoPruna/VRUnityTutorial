using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 2;

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(transform.forward * Time.deltaTime * speed);
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
