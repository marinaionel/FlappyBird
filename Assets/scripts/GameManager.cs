using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;

public class GameManager : MonoBehaviour
{
    public GameObject losePanel;
    public Transform bird;
    public Transform pipePrefab;
    public int spawnInAdvance;
    public int pipeDistance;
    private int _lastSpawn = 5;

    public void onRetryClick()
    {
        SceneManager.LoadScene("Game");
    }

    public void onLose()
    {
        losePanel.SetActive(true);
    }

    private void Update()
    {
        if (_lastSpawn < bird.position.x + spawnInAdvance)
        {
            Instantiate(pipePrefab, new Vector3(_lastSpawn, Random.Range(-2, 2), 0), Quaternion.identity);
            _lastSpawn += pipeDistance;
        }
    }
}