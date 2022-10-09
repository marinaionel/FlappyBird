using System;
using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int force;
    public MoveCamera moveCamera;
    public Rigidbody2D rb;
    public GameManager gameManager;
    private bool _lost;
    public TMP_Text distanceText;
    public TMP_Text highestScore;

    // Update is called once per frame
    void Update()
    {
        if (_lost) return;
        distanceText.text = "Distance: " + (int)transform.position.x;
        transform.Translate(Vector2.right * Time.deltaTime);
        if (Input.GetMouseButtonDown(0))
            rb.AddForce(Vector2.up * force, ForceMode2D.Impulse);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.gameObject.CompareTag("Pipe")) return;
        _lost = true;
        gameManager.onLose();
        Destroy(moveCamera);
        var lostDistance = (int)transform.position.x;
        var high = PlayerPrefs.GetInt("highest", 0);
        var max = Math.Max(lostDistance, high);
        PlayerPrefs.SetInt("highest", max);
        highestScore.text = "Highest score: " + max;
        PlayerPrefs.Save();
    }
}