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

    public float countdown = 10;
    public TMP_Text timer;

    public GameObject countdownPanel;

    bool begin = false;

    void Start()
    {
        MenuCanvas.SetActive(true);
        KillCanvas.SetActive(false);
        //pauseCanvas.SetActive(false);
        InstructionsPanel.SetActive(false);
        countdownPanel.SetActive(false);
    }

    
    void Update()
    {
        //if (OVRInput.Get(OVRInput.RawButton.X)){

        //uiActive = !uiActive;//}

        //KillCanvas.SetActive(uiActive);

        if (OVRInput.Get(OVRInput.RawButton.B))
        {
            MenuCanvas.SetActive(false);
            InstructionsPanel.SetActive(false);
            KillCanvas.SetActive(true);
            countdownPanel.SetActive(true);
            begin = true;
        }

        if (begin)
        {
            countdown -= Time.deltaTime;

            if(countdown >= 0)
            {
                //begin spawning
                countdownPanel.SetActive(false);
            }
        }

        timer.text = countdown.ToString("");
        
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
