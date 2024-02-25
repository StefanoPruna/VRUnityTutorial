using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Globalization;

public class ClockWall : MonoBehaviour
{
    const float hoursToDegrees = 30f, minutesToDegrees = 6f, secondsToDegrees = 6f;

    [SerializeField]
    Transform hoursPivot, minutesPivot, secondsPivot;

    // Start is called before the first frame update
    void Start()
    {
        //DateTime localDate = DateTime.Now;
        //DateTime utcDate = DateTime.UtcNow;
        //String[] cultureNames = { "en-US", "en-GB", "fr-FR",
        //                        "de-DE", "ru-RU" };

        //foreach (var cultureName in cultureNames)
        //{
        //    var culture = new CultureInfo(cultureName);
        //    Console.WriteLine("{0}:", culture.NativeName);
        //    Console.WriteLine("   Local date and time: {0}, {1:G}",
        //                      localDate.ToString(culture), localDate.Kind);
        //    Console.WriteLine("   UTC date and time: {0}, {1:G}\n",
        //                      utcDate.ToString(culture), utcDate.Kind);
        //}
    }

    // Update is called once per frame
    void Update()
    {
        var time = DateTime.Now;
        hoursPivot.localRotation =
            Quaternion.Euler(0f, 0f, hoursToDegrees * time.Hour);
        minutesPivot.localRotation =
            Quaternion.Euler(0f, 0f, minutesToDegrees * time.Minute);
        secondsPivot.localRotation =
            Quaternion.Euler(0f, 0f, secondsToDegrees * time.Second);
    }
}
