using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraModeSwitching : MonoBehaviour
{
    public GameObject MainCamera;
    public GameObject NearCamera;
    public GameObject FaceCamera;

    int cameraMode;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            ChangeCamera();
        }
    }

    void ChangeCamera()
    {
        cameraMode++;

        if (cameraMode >= 3) 
        {
            cameraMode = 0;
        }

        switch (cameraMode)
        {
                case 0:
                MainCamera.SetActive(true);
                NearCamera.SetActive(false);
                FaceCamera.SetActive(false);
                break;
            case 1:
                MainCamera.SetActive(false);
                NearCamera.SetActive(true);
                FaceCamera.SetActive(false);
                break;
            case 2:
                MainCamera.SetActive(false);
                NearCamera.SetActive(false);
                FaceCamera.SetActive(true);
                break;
        }

    }
}
