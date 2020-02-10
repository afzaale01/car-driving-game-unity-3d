using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FinishPoint : MonoBehaviour
{

    public GameObject MinutDisplay;
    public GameObject SecondDisplay;
    public GameObject MilliBox;
    public GameObject Laptimer;
    public GameObject HalfTimer;
    public GameObject LapCounterTxt;
    public GameObject TotalLapTxt;
    public GameObject RaceFinish;
    public int LapCounter;
    public int TotalLap;

    private void Start()
    {
        MilliBox.GetComponent<Text>().text = PlayerPrefs.GetFloat("MilSec").ToString("F0");
        SecondDisplay.GetComponent<Text>().text = PlayerPrefs.GetInt("Second").ToString() + ".";
        MinutDisplay.GetComponent<Text>().text = PlayerPrefs.GetInt("Minut").ToString() + ":";
        TotalLapTxt.GetComponent<Text>().text = "/ " + TotalLap.ToString();
        Laptimer.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
               

        if (lapTimeManger.SecondCount <= 9)
        {
            SecondDisplay.GetComponent<Text>().text = "0" + lapTimeManger.SecondCount + ".";
        }
        else
        {
            SecondDisplay.GetComponent<Text>().text = "" + lapTimeManger.SecondCount + ".";

        }

        
        if (lapTimeManger.MinutCount <= 9)
        {
            MinutDisplay.GetComponent<Text>().text = "0" + lapTimeManger.MinutCount + ".";
        }
        else
        {
            MinutDisplay.GetComponent<Text>().text = "" + lapTimeManger.MinutCount + ".";

        }

        LapCounter++;

        

        MilliBox.GetComponent<Text>().text = "" + lapTimeManger.MilliCount;
        LapCounterTxt.GetComponent<Text>().text = LapCounter.ToString();
        PlayerPrefs.SetFloat("MilSec",lapTimeManger.MilliCount);
        PlayerPrefs.SetInt("Second",lapTimeManger.SecondCount);
        PlayerPrefs.SetInt("Minut",lapTimeManger.MinutCount);



        lapTimeManger.MilliCount = 0;
        lapTimeManger.MinutCount = 0;
        lapTimeManger.SecondCount = 0;

        if (LapCounter >= TotalLap)
        {
            RaceFinish.SetActive(true);
        }


        HalfTimer.SetActive(true);
        Laptimer.SetActive(false);
    }
    
}
