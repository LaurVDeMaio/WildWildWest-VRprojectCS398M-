using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    public float speed = 3;
    public GameObject player;

    void Start()
    {
        Destroy(this.gameObject, 15);
        player = GameObject.Find("Player");
    }


    void Update()
    {
        transform.LookAt(player.transform.position);
        transform.Translate(-transform.right * speed * Time.deltaTime);
    }
}
