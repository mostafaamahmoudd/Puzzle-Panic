using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wireend : MonoBehaviour
{
   [SerializeField] private GameObject wireSystem;
   [SerializeField] private GameObject[] wires;
   [SerializeField] int allwires = 0;
    [SerializeField] int correctingwire=0;
    void Start()
    {
        allwires = wireSystem.transform.childCount;
        wires = new GameObject[allwires];
        for (int i = 0; i <wires.Length; i++)
        {
            wires[i] = wireSystem.transform.GetChild(i).gameObject;
        }
    }
    [SerializeField] private Rigidbody2D Player;
    [SerializeField] private GameObject puzzle;
    [SerializeField] private GameObject mach;
    [SerializeField] private GameObject mach1;



    public void puzzleManeger()
    {
        correctingwire += 1;
        if (correctingwire == allwires && correctingwire == 23)
        {
            Player.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
            
            puzzle.SetActive(false);
            mach.SetActive(true);
            mach1.SetActive(false);





        }
    }
}
