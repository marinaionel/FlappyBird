using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject losePanel;

    public void onRetryClick()
    {
        SceneManager.LoadScene("Game");
    }

    public void onLose()
    {
        losePanel.SetActive(true);
    }
}