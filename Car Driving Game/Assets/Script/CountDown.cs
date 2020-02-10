using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Vehicles.Car;

public class CountDown : MonoBehaviour
{
    [Header("Car Color Selection")]
    public GameObject CarBody;

    [Header("Car Selection")]
    public GameObject CountDownTxt;
    public AudioSource sfx;
    public AudioClip GetReady;
    public AudioClip GoAudio;
    public AudioSource BGM;
    public GameObject LapTimer;
    public CarUserControl CarController;
    public CarAIControl CarAIControl;
    // Start is called before the first frame update
    void Start()
    {
        if (SelectionManager.selectedColor == ColorSelected.red)
        {
            CarBody.GetComponent<Renderer>().material.color = Color.red;
        }
        if (SelectionManager.selectedColor == ColorSelected.black)
        {
            CarBody.GetComponent<Renderer>().material.color = Color.black;
        }

        if (SelectionManager.mode == 0)
        {
            CarAIControl.gameObject.SetActive(false);
        }if (SelectionManager.mode == 1)
        {
            CarAIControl.gameObject.SetActive(true);
        }


        StartCoroutine(CountDownStart());
    }

    IEnumerator CountDownStart()
    {
        yield return new WaitForSeconds(0.5f);
        CountDownTxt.GetComponent<Text>().text = "3";
        sfx.PlayOneShot(GetReady);
        CountDownTxt.SetActive(true);
        yield return new WaitForSeconds(1f);
        CountDownTxt.SetActive(false);
        CountDownTxt.GetComponent<Text>().text = "2";
        sfx.PlayOneShot(GetReady);
        CountDownTxt.SetActive(true);
        yield return new WaitForSeconds(1f);
        CountDownTxt.SetActive(false);
        CountDownTxt.GetComponent<Text>().text = "1";
        sfx.PlayOneShot(GetReady);
        CountDownTxt.SetActive(true);
        yield return new WaitForSeconds(1f);
        CountDownTxt.SetActive(false);
        sfx.PlayOneShot(GoAudio);
        BGM.Play();
        LapTimer.SetActive(true);
        CarController.enabled = true;
        CarAIControl.enabled = true;

    }
}
