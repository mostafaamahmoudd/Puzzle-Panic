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
        if (collision.gameObject.CompareTag("Trap"))
        {
            Die();
        }
    }
    private void Die()
    {
        Death_rb.bodyType = RigidbodyType2D.Static;
        Death.SetTrigger("Death");
        Deathsound.Play();

    }

    private void Reatart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}

