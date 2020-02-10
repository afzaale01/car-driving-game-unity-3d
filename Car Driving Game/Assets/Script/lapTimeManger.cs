using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class lapTimeManger : MonoBehaviour
{
    public static int MinutCount;
    public static int SecondCount;
    public static float MilliCount;
    public static string MilliDisplay;

    public GameObject MinutDisplay;
    public GameObject SecondDisplay;
    public GameObject MilliBox;

    // Update is called once per frame
    void Update()
    {
        MilliCount += Time.deltaTime * 10;
        MilliDisplay = MilliCount.ToString("F0");
        MilliBox.GetComponent<Text>().text = "" + MilliDisplay;

        if (MilliCount >= 10)
        {
            MilliCount = 0;
            SecondCount += 1;
        }

        if (SecondCount <= 9)
        {
            SecondDisplay.GetComponent<Text>().text = "0" + SecondCount + ".";
        }
        else {
            SecondDisplay.GetComponent<Text>().text = "" + SecondCount + ".";

        }

        if (SecondCount >= 60)
        {
            SecondCount = 0;
            MinutCount += 1;
        }
        if (MinutCount <= 9)
        {
            MinutDisplay.GetComponent<Text>().text = "0" + MinutCount + ":";
        }
        else
        {
            MinutDisplay.GetComponent<Text>().text = "" + MinutCount + ":";

        }



    }
}
