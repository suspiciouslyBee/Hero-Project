using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{


    //public static GameManager Instance;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //Bounds check
        Vector3 correctedPos = GameManager.Instance.playerCam.WorldToViewportPoint(transform.position);
        float horizontalBound = GameManager.Instance.playerCam.ScreenToWorldPoint(Vector3.right).x;
        float verticalBound = GameManager.Instance.playerCam.ScreenToWorldPoint(Vector3.up).y;


        //bounds checking before moving
        if(0 > correctedPos.x || correctedPos.x > 1) {
            Destroy(gameObject);
        } 

        if(0 > correctedPos.y || correctedPos.y > 1) {
            Destroy(gameObject);
        }

        
    }
}
