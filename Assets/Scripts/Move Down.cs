using UnityEngine;

public class MoveDown : MonoBehaviour
{
    public float speed = 1f; // Speed at which the fruit will move down

    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);
    }
}
