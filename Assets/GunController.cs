using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    public GameObject projectile;
    Transform launcher;

    float timer = 0.75f;
    float coolDown = 0.75f;

    int bulletCount = 6;

    public int kills = 0;

    void Start()
    {
        launcher = transform.Find("launcher");
    }

    
    void Update()
    {
        timer += Time.deltaTime;

        if (OVRInput.Get(OVRInput.Button.One) && bulletCount > 0)
        {
            if(timer >= coolDown) {
                var go = Instantiate(projectile, launcher.position, launcher.rotation);
                var pc = go.GetComponent<ProjectileController>();
                pc.Fire(this);
                //bulletCount--;
                timer = 0f;
            }

        }
        else if(bulletCount < 0)
        {
            //reload
        }



    }
}
