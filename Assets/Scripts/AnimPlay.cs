using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AnimPlay : MonoBehaviour
{
    [SerializeField] private GameObject Player;
    [SerializeField] private GameObject plane;
    [SerializeField] private Text info;

    private void OnTriggerEnter2D(Collider2D collider2D)
    {
        info.enabled = true;
        if (Input.GetKeyDown(KeyCode.Z)&&collider2D.gameObject.CompareTag("Player"))
        {
            Player.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
            plane.SetActive(true);
        }
    }
}

