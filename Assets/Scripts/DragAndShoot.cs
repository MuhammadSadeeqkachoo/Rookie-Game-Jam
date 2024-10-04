using System.ComponentModel;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(Collider))]
public class DragAndShoot : MonoBehaviour
{
    private Vector3 mousePressDownPos;
    private Vector3 mouseReleasePos;

    private Rigidbody rb;

    private bool isShoot;

    void Start()
    {

        rb = GetComponent<Rigidbody>();
        rb.isKinematic = true;

    }

    private void OnMouseDown()
    {
        mousePressDownPos = Input.mousePosition;
        
    }

    private void OnMouseUp()
    {
        mouseReleasePos = Input.mousePosition;
        Shoot( mousePressDownPos - mouseReleasePos);
    }

    private float forceMultiplier = 10;
    void Shoot(Vector3 Force)
    {
        if (isShoot)
            return;
        rb.isKinematic = false;
        rb.AddForce(new Vector3(Force.x, Force.y, Force.y) * forceMultiplier);
        isShoot = true;
        Destroy(gameObject, 2);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.CompareTag("Fruits"))
        Debug.Log("you Hit Fruits");
    }


}