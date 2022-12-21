using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileController : MonoBehaviour
{
    GunController player;

    public void Fire(GunController gc)
    {
        player = gc;
        GetComponent<Rigidbody>().AddForce(transform.forward * 50, ForceMode.Impulse); 
        Destroy(this.gameObject, 3); //change time
    }

    //private void OnTriggerEnter(Collider other)
    //{
    //    var go = other.gameObject;

    //    if (go.tag == "Enemy")
    //    {
    //        EnemyMover e = go.GetComponent<EnemyMover>();
    //        e.TakeDamage();
    //        //player.kills++;

    //    }

        
    //}

}
