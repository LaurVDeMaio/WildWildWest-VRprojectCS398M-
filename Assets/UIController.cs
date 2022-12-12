using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    public GameObject UICanvas;
    public GameObject LaserPointer;

    bool uiActive = false;

    void Start()
    {
        UICanvas.SetActive(false);
        LaserPointer.SetActive(false);
    }

    
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.RawButton.X))
        {
            uiActive = !uiActive;
            UICanvas.SetActive(uiActive);
            LaserPointer.SetActive(uiActive);
        }

    }

    public void ResetLevel()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("SampleScene");
    }
}
