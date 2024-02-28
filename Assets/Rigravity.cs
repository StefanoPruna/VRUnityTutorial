using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rigravity : MonoBehaviour
{
    public Rigidbody rigidbody;

    void OnCollisionEnter(Collision targetObj)
    {
        if (targetObj.gameObject.tag == "RightSaber")
            rigidbody.useGravity = true;
    }
}
