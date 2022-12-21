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

    public GameObject EnemySpawner;

    
    void Start()
    {
        MenuCanvas.SetActive(true);
        KillCanvas.SetActive(false);
        pauseCanvas.SetActive(false);
        InstructionsPanel.SetActive(false);

        EnemySpawner.SetActive(false);
    }

    
    void Update()
    {
        if (OVRInput.Get(OVRInput.RawButton.B))
        {
            MenuCanvas.SetActive(false);
            InstructionsPanel.SetActive(false);
            KillCanvas.SetActive(true);

            //start spawning
            EnemySpawner.SetActive(true);
        }

       
    }

    public void Instructions()
    {
       InstructionsPanel.SetActive(true);
    }


    public void Restart()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainGame");
        GunController.kills = 0;
    }

    public void Menu()
    {
        KillCanvas.SetActive(false);
        pauseCanvas.SetActive(true);
        
    }

    public void Resume()
    {
        pauseCanvas.SetActive(false);
        KillCanvas.SetActive(true);
    }

    public void PlayGame()
    {
        MenuCanvas.SetActive(false);
        KillCanvas.SetActive(true);

        //start spawning
        EnemySpawner.SetActive(true);
    }
}
