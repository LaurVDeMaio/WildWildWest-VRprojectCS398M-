using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject cowboy;

    float t = 3.5f;
 
    void Update()
    {
        t -= Time.deltaTime;

        if (t <= 0)
        {
            t = Random.Range(1.0f, 2.0f);

            var pos = new Vector3(Random.Range(-47, -45), 2, 29);

            Instantiate(cowboy, pos, Quaternion.identity);
            
        }
    }
}
