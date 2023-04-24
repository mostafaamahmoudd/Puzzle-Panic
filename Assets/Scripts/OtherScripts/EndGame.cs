using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
   
        public void Quit()
        {

            Application.Quit();
        }

        public void Restart()
        {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }


  
}
