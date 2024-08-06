using TMPro;
using UnityEngine;

public class hit : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Fruits"))
        {
            Debug.Log("you hit fruit");
            Destroy(collision.collider.gameObject);

        }

    }
}
