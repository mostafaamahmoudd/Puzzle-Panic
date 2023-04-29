using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class die : MonoBehaviour
{
    public GameObject SetActive;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            SetActive.SetActive(true);
            SetActive.GetComponent<Animator>().enabled = true;
        }
        else
        {
            SetActive.SetActive(false);
        }
    }
}
