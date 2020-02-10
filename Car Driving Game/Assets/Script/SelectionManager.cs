using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
[System.Serializable]
public enum ColorSelected 
{
    red,
    black
}

public class SelectionManager : MonoBehaviour
{

    public static ColorSelected selectedColor;
    public static int mode;
    public GameObject CarSelectionPanel;
    public GameObject ModeSelectionPanel;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void RedSelection()
    {
        selectedColor = ColorSelected.red;
        ModeSelectionPanel.SetActive(true);
        CarSelectionPanel.SetActive(false);
        //SceneManager.LoadScene("SampleScene");
    }
    public void BlackSelection()
    {
        selectedColor = ColorSelected.black;
        ModeSelectionPanel.SetActive(true);
        CarSelectionPanel.SetActive(false);
        //SceneManager.LoadScene("SampleScene");
    }

    public void ModeSelection(int i)
    {
        mode = i;
        SceneManager.LoadScene("SampleScene");
    }



}
