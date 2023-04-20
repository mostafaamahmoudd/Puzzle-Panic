using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AnimPlay : MonoBehaviour
{
    [SerializeField] private GameObject Player;
    [SerializeField] private GameObject plane;
    private void OnTriggerEnter2D(Collider2D collider2D)
    {
        
            if (collider2D.gameObject.CompareTag("Player"))
            {
                Player.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
                plane.SetActive(true);
            gameObject.GetComponent<BoxCollider2D>().enabled = false;
        }
        
    }
}

