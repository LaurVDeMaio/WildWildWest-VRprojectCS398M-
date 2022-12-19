using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UiController : MonoBehaviour
{
    bool uiActive = false;

    public GameObject Canvas;
    public LineRenderer Laser;

    void Start()
    {
        //Canvas.SetActive(false);
        
    }

    
    void Update()
    {
        //if (OVRInput.Get(OVRInput.RawButton.X)){

            uiActive = !uiActive;
            Canvas.SetActive(uiActive);
        //}
    }

    public void Restart()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainGame");
    }
}
