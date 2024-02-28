using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LgravityToggle : MonoBehaviour
{
    public Rigidbody rigidbody;

    void OnCollisionEnter(Collision targetObj)
    {
        if (targetObj.gameObject.tag == "LeftSaber")
            rigidbody.useGravity = true;
    }
}
