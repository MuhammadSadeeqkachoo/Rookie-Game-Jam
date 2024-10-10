using System.Collections;
using TMPro;
using UnityEngine;
using Dweiss;


public class SlingshotMechanic : MonoBehaviour
{
    public GameObject stonePrefab, cube;
    public float launchForce = 10;
    public int maxStones = 5;
    private int currentStones = 5;
    [SerializeField]
    Rigidbody rb,cubeRb;
    
    [SerializeField]
    Joystick jk;
    [SerializeField]
    TMP_Text stonecount;
    float v ;
    float h;


    private bool hasLaunched = false;
    private bool aim = false;

    private void Awake()
    {
        stonecount.text = $"Stones 5/5";
        
    }


    private void Update()
    {

        if (jk != null  && currentStones > 0 ) 
        {
            if(jk.Horizontal != 0 || jk.Vertical != 0) 
            {
                v = jk.Vertical;
                h = jk.Horizontal;
                //if (!aim)
                //{
                //    StartCoroutine(Aim());
                //}
            }

            if (Input.GetMouseButtonUp(0))
            {
                //StopCoroutine(Aim());
                LaunchStone();
                stonecount.text = $"Stones {currentStones}/{maxStones}";
            }
            
            

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
                rb.AddForce(-new Vector3(h,v,v) * launchForce, ForceMode.Impulse);
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

    // IEnumerator Aim()
    //{
    //    Instantiate(cube,transform.position,Quaternion.identity);
    //    cubeRb = cube.GetComponent<Rigidbody>();
    //    rb.AddForce(-new Vector3(h, v, v) * launchForce, ForceMode.Impulse);
    //    Destroy(cube, 3);//Destroy After 3 seconds
    //    yield return new WaitForSeconds(1);
    //    aim = true;


    //}

}
