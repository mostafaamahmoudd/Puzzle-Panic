using UnityEngine.SceneManagement;
using UnityEngine;

public class StartEnd : MonoBehaviour
{
    public int num =0;
    public void Buttons()
    {
        SceneManager.LoadScene(num);
    }
    public void exit()
    {
        Application.Quit();
    }
}
