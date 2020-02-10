using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfPoint : MonoBehaviour
{
    public GameObject Laptimer;
    public GameObject HalfTimer;

    private void OnTriggerEnter(Collider other)
    {
        Laptimer.SetActive(true);

        HalfTimer.SetActive(false);
    }
}
