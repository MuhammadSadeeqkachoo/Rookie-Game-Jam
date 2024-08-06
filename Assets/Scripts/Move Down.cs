using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveDown : MonoBehaviour
{

    public float speed = 2f; // Speed at which the fruit will move down


    private void Start()
    {
       
    }
    void Update()
    {
        
        transform.Translate(Vector3.down * speed * Time.deltaTime);
    }

}
