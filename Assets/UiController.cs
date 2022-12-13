using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UiController : MonoBehaviour
{
    bool uiActive = false;

    public GameObject Canvas;
    public LineRenderer Laser;

    GunController gc;

    public TMP_Text kill;

    void Start()
    {
        Canvas.SetActive(false);

        gc = GetComponent<GunController>();
       
    }

    
    void Update()
    {
        if (OVRInput.Get(OVRInput.RawButton.X)){
            uiActive = !uiActive;

            Canvas.SetActive(uiActive);

            kill.text = gc.kills.ToString("");
           
        }
    }

    public void Restart()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainGame");
    }
}
