using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doorway : MonoBehaviour
{
    public GameObject Portal;
    private GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }
    public GameObject P1;
    public GameObject P2;
    public Camera cam1;
    public Camera cam2;
  
    
    
    private void OnMouseDown()
    {
       
            Player.transform.position = new Vector2(Portal.transform.position.x, Portal.transform.position.y);
            P1.SetActive(false);
            P2.SetActive(true);
            cam1.enabled = false;
            cam2.enabled = true;
        

    }
}
