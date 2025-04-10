using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private bool mouseControl = true;
    public delegate void MovementDelegate();
    MovementDelegate movementMode; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //start with the mousemovement behavior
        movementMode = MouseMovement;
    }

    // Update is called once per frame
    void Update()
    {
        movementMode();
    }

    //"glues" the player to the mouse
    void MouseMovement() {
        //corrects the screen to world pos to infront of the cam
        Vector3 correctedPos = Camera.main.ScreenToWorldPoint(Input.mousePosition) +  new Vector3(0,0,1);
        transform.position = correctedPos;
    }

    
}
