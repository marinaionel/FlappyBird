using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int force;
    public MoveCamera moveCamera;
    public Rigidbody2D rb;
    public GameManager gameManager;
    private bool lost;
    public TMP_Text distanceText;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (lost) return;
        distanceText.text = "Distance: " + (int)transform.position.x;
        transform.Translate(Vector2.right * Time.deltaTime);
        if (Input.GetMouseButtonDown(0))
            rb.AddForce(Vector2.up * force, ForceMode2D.Impulse);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.gameObject.CompareTag("Pipe")) return;
        lost = true;
        gameManager.onLose();
        Destroy(moveCamera);
        Debug.Log("Failed");
    }
}