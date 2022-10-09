using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenMenu : MonoBehaviour
{
    public void OnMenuClick()
    {
        SceneManager.LoadScene("Menu");
    }
}