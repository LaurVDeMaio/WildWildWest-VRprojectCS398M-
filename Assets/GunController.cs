using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GunController : MonoBehaviour
{
    public GameObject projectile;
    Transform launcher;

    //may be best to replace this with a raycast - ATD

    float timer = 0.75f;
    float coolDown = 0.75f;

    public int kills = 0;
    public TMP_Text kill;

    void Start()
    {
        launcher = transform.Find("launcher");
    }

    
    void Update()
    {
        timer += Time.deltaTime;
        kill.text = kills.ToString("");

        if (OVRInput.Get(OVRInput.Axis1D.SecondaryIndexTrigger) > 0.2f)
        {
            if(timer >= coolDown) {
                var go = Instantiate(projectile, launcher.position, launcher.rotation);
                var pc = go.GetComponent<ProjectileController>();
                pc.Fire(this);
                timer = 0f;
            }

        }
        
        if(kills >= 15)
        {
            
        }


    }
}
