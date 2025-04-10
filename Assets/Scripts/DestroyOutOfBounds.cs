using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{


    public GameManager Instance;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //Bounds check
        Vector3 correctedPos = Instance.playerCam.WorldToViewportPoint(transform.position);
        float horizontalBound = Instance.playerCam.ScreenToWorldPoint(Vector3.right).x;
        float verticalBound = Instance.playerCam.ScreenToWorldPoint(Vector3.up).y;


        //bounds checking before moving
        if(0 > correctedPos.x || correctedPos.x > 1) {
            Destroy(gameObject);
        } 

        if(0 > correctedPos.y || correctedPos.y > 1) {
            Destroy(gameObject);
        }

        
    }
}
