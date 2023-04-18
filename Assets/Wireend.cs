using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wireend : MonoBehaviour
{
    public GameObject wireSystem;
    public GameObject[] wires;
   [SerializeField] int allwires = 0;
    int correctingwire=0;
    void Start()
    {
        allwires = wireSystem.transform.childCount;
        wires = new GameObject[allwires];
        for (int i = 0; i <wires.Length; i++)
        {
            wires[i] = wireSystem.transform.GetChild(i).gameObject;
        }
    }
    public GameObject Player;
    public GameObject puzzle;
    public Animator Machine;


    public void puzzleManeger()
    {
        correctingwire += 1;
        if (correctingwire == allwires)
        {
            Player.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
            puzzle.SetActive(false);
            Machine.enabled=true;

        }
    }
}
