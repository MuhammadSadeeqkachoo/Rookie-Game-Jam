using System.Collections;
using TMPro;
using UnityEngine;

public class SlingshotMechanic : MonoBehaviour
{
    public GameObject stonePrefab;
    public float launchForce = 20;
    public int maxStones = 5;
    private int currentStones = 5;
    Rigidbody rb;
    [SerializeField]
    Joystick jk;
    [SerializeField]
    TMP_Text stonecount;


    private bool hasLaunched = false;

    private void Awake()
    {
        stonecount.text = $"Stones 5/5";
        
    }

    private void Update()
    {
        if (jk != null && jk.Vertical != 0 && currentStones > 0) 
        {
             LaunchStone();
             stonecount.text = $"Stones {currentStones}/{maxStones}";
            

        }

        else if(currentStones == 0)
        {
            Debug.Log("Game Over");
            
        }
    }

    private void LaunchStone()
    {
        if (!hasLaunched)
        {
            GameObject stone = Instantiate(stonePrefab, transform.position, transform.rotation);
            rb = stone.GetComponent<Rigidbody>();
            rb.AddForce(transform.forward * launchForce, ForceMode.Impulse);
            Destroy(stone, 3);//Destroy After 3 seconds
            currentStones--;
            hasLaunched = true;
            StartCoroutine(ToggleLaunch());
        }
    }

    IEnumerator ToggleLaunch()
    {
        yield return new WaitForSeconds(1);
        hasLaunched = false;
    }


 
}
