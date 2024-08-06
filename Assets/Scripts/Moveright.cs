using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Moveright : MonoBehaviour
{

    public float speed = 3f; // Speed at which the fruit will move down
    int sceneIndex;


    private void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene();

        // Get the scene index (number) from the build settings
        sceneIndex = currentScene.buildIndex;
    }
    void Update()
    {
        if(sceneIndex == 3)
        transform.Translate(Vector3.right * speed * Time.deltaTime);
        if(transform.position.x > 12) { Destroy(gameObject); }
    }

}
