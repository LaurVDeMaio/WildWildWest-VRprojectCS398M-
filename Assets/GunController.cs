using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GunController : MonoBehaviour
{
    public GameObject projectile;
    Transform launcher;

    //may be best to replace this with a raycast - ATD
    AudioSource src;
    public AudioClip clip;
    float timer = 0.75f;
    float coolDown = 0.75f;
    public LayerMask l;
    public static int kills = 0;
    public TMP_Text kill;

    void Start()
    {
        src = GetComponent<AudioSource>();
        launcher = transform.Find("launcher");
    }

    
    void Update()
    {
        timer += Time.deltaTime;
        kill.text = kills.ToString("");

        if (OVRInput.Get(OVRInput.Axis1D.SecondaryIndexTrigger) > 0.2f)
        {
            if(timer >= coolDown) {
                timer = 0f;
                var go = Instantiate(projectile, launcher.position, launcher.rotation);
                var pc = go.GetComponent<ProjectileController>();
                pc.Fire(this);
                src.PlayOneShot(clip);
                
                RaycastHit hitinfo;
                if (Physics.Raycast(launcher.position, launcher.transform.forward, out hitinfo, 200f, l)) {
                    EnemyMover e = hitinfo.collider.gameObject.GetComponent<EnemyMover>();
                    //GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    //cube.transform.position = hitinfo.transform.position;
                    e.TakeDamage();
                }
            }

        }
        
        if(kills >= 15)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("MainGame");
        }


    }
}
