using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ADLDLaser : MonoBehaviour
{
    GameObject player;
    LineRenderer lr;
    float range = 50;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        lr = GetComponent<LineRenderer>();
    }


    void Update()
    {
        var endPos = transform.TransformPoint(0, 0, range);

        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.forward, out hit, range))
        {
            if(OVRInput.Get(OVRInput.Button.One) && hit.collider.tag == "Enemy")
            {
                
            }

        }

        lr.SetPosition(0, transform.position);
        lr.SetPosition(1, endPos);

    }
}
