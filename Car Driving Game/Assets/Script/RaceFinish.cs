using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;
public class RaceFinish : MonoBehaviour
{

    public GameObject carController;
    public GameObject FinishCamera;
    public GameObject ViewMode;
    public GameObject LevelMusic;
    public GameObject CompleteTrig;
    public AudioSource FinishMusic;
    public GameObject EndUI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        this.GetComponent<BoxCollider>().enabled = false;
        carController.SetActive(false);
        CompleteTrig.SetActive(false);
        carController.GetComponent<CarController>().m_Topspeed= 0.0f;
        carController.GetComponent<CarController>().enabled = false;
        carController.GetComponent<CarUserControl>().enabled = false;

        carController.SetActive(true);
        FinishCamera.SetActive(true);

        LevelMusic.SetActive(false);
        ViewMode.SetActive(false);
        FinishMusic.Play();

        EndUI.SetActive(true);

    }

    public void Restart()
    {
        UnityEngine.SceneManagement.Scene  loaddedScene = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        UnityEngine.SceneManagement.SceneManager.LoadScene(loaddedScene.name);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
