using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    public GameObject projectile;
    Transform launcher;

    void Start()
    {
        launcher = transform.Find("launcher");
    }

    
    void Update()
    {
        if (OVRInput.Get(OVRInput.Button.One))
        {
            var go = Instantiate(projectile, launcher.position, launcher.rotation);
            var pc = go.GetComponent<ProjectileController>();
            pc.Fire(this);
        }
    }
}
