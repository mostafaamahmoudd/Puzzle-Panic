using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saw : MonoBehaviour
{[SerializeField] string name = "Saw";
    [SerializeField] private Animator cutdown;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(name))
        {
            cutdown.enabled = true;
        }
    }
}
