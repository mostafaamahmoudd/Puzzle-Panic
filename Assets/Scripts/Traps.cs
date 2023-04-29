using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Traps : MonoBehaviour
{
    private Rigidbody2D Death_rb;
    private Animator Death;
    [SerializeField] private AudioSource Deathsound;
    void Start()
    {
        Death = GetComponent<Animator>();
        Death_rb = GetComponent<Rigidbody2D>();

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (gameObject.CompareTag("Player"))
        {
            if (collision.gameObject.CompareTag("Trap")|| collision.gameObject.CompareTag("PLayer"))
            {

                Die();
            }
        }
        else if (gameObject.CompareTag("PLayer"))
        {
            if (collision.gameObject.CompareTag("Trap"))
            {

                Destroy(gameObject, time);
            }
        }
    }
    private void Die()
    {
        Death_rb.bodyType = RigidbodyType2D.Static;
        Death.SetTrigger("Death");
        Deathsound.Play();

    }
   
    public int gameover = 2;
    public int time = 2;
    private void Reatart()
    {
            SceneManager.LoadScene(gameover);
    }
    

}

