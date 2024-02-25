using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;

public class Clock : MonoBehaviour
{
    private Transform clockHandTransform;

    private void Awake()
    {
        clockHandTransform = transform.Find("clockHand");
    }

    private void Update()
    {
        clockHandTransform.eulerAngles = new Vector3(0, 0, -Time.realtimeSinceStartup * 90f);
    }
}
