using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodShoot : MonoBehaviour
{

    private Animator Shoot;
    private void Start()
    {
        Shoot = gameObject.GetComponent<Animator>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Shoot.enabled = true;
        }
    }
    [SerializeField] private Transform Shootpos;
    [SerializeField] private GameObject Wood;
    public void woodshoot()
    {
        Instantiate(Wood, Shootpos.position, Shootpos.rotation);
    }
}
