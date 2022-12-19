using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    #region Gameplay
    int health = 3;
    public float speed = 3;
    public GameObject player;
    bool alive = true;
    #endregion

    #region Audio
    AudioSource src;
    public AudioClip damageSound;
    public AudioClip deathSound;
    #endregion

    #region Animation
    Animator anim;
    #endregion

    void Start()
    {
        anim = GetComponent<Animator>(); //animate damage and death
        src = GetComponent<AudioSource>();
        Destroy(this.gameObject, 15);
        player = GameObject.Find("Player");
    }


    void Update()
    {

        if (alive) {
            transform.LookAt(player.transform.position);
            transform.Translate(-transform.right * speed * Time.deltaTime);
        }
        
    }

    public void TakeDamage() {

        health--;
        if (health > 1) {
            anim.SetTrigger("Damage"); //make triggers for these (anims + sounds etc particles all done
            src.PlayOneShot(damageSound);
        }
        if (health <= 0) {
            anim.SetTrigger("Death");
            src.PlayOneShot(deathSound);
            alive = false;
            StartCoroutine("DieCoroutine");

        }
    
    }

    IEnumerator DieCoroutine() {

        yield return new WaitForSeconds(deathSound.length);
        Destroy(gameObject);

    }
}
