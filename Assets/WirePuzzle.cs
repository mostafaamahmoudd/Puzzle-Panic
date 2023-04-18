using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WirePuzzle : MonoBehaviour
{
    float[] Rotations = { 0, 90, 180, 270 };
    public float[] correctrot;
    int trueposs = 1;
    [SerializeField] private bool isright = false;
    Wireend gameManager;
    private void Awake()
    {
        gameManager = GameObject.Find("Wireend").GetComponent<Wireend>();
    }
    private void Start()
    {
        int rand = Random.Range(0, Rotations.Length);
        transform.eulerAngles = new Vector3(0, 0, Rotations[rand]);
        trueposs = correctrot.Length;
        if (trueposs > 1)
        {
            if (transform.eulerAngles.z == correctrot[0] || transform.eulerAngles.z == correctrot[1])
            {
                isright = true;
                gameManager.puzzleManeger();
            }
        }
        else
        {
            if (transform.eulerAngles.z == correctrot[0])
            {
                isright = true;
            }
        }
    }
    private void OnMouseDown()
    {
        transform.Rotate(new Vector3(0, 0, 90));

        if (trueposs > 1)
        {
            if (transform.eulerAngles.z == correctrot[0] || transform.eulerAngles.z == correctrot[1] && isright == false)
            {
                isright = true;
                gameManager.puzzleManeger();

            }
            else if (isright == true)
            {
                isright = false;
            }
        }
        else
        {
            if (transform.eulerAngles.z == correctrot[0]  && isright == false)
            {
                isright = true;
            }
            else if (isright == true)
            {
                isright = false;
            }
        }
    }
}
