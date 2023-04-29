using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lastlevel : MonoBehaviour
{
    [SerializeField] private GameObject Player;
    [SerializeField] private GameObject plane;
    [SerializeField] private GameObject box;
    [SerializeField] private GameObject box1;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Player.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
            plane.SetActive(false);
            box.SetActive(false);
            box1.SetActive(true);
        }

    }
}
