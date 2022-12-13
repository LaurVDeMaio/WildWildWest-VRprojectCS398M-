using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    public float speed = 3;

    void Start()
    {
        Destroy(this.gameObject, 15);
    }


    void Update()
    {
        transform.Translate(-transform.right * speed * Time.deltaTime);
    }
}
