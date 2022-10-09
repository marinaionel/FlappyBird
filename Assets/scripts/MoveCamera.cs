using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * Time.deltaTime);
    }
}