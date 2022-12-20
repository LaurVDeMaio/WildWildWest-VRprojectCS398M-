using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UiController : MonoBehaviour
{
    bool uiActive = false;

    public GameObject KillCanvas;
    public LineRenderer Laser;

    public GameObject MenuCanvas;
    public GameObject pauseCanvas;
    public GameObject InstructionsPanel;

    void Start()
    {
        MenuCanvas.SetActive(true);
        KillCanvas.SetActive(false);
        //pauseCanvas.SetActive(false);
        InstructionsPanel.SetActive(false);
    }

    
    void Update()
    {
        //if (OVRInput.Get(OVRInput.RawButton.X)){

            //uiActive = !uiActive;//}

        //KillCanvas.SetActive(uiActive);
        
    }

    public void Instructions()
    {
       InstructionsPanel.SetActive(true);
    }


    public void Restart()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainGame");
    }
}
