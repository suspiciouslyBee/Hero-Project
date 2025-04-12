using System.Collections;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    //Keyboard Stuff
    public float horizontalInput;
    public float verticalInput;
    public float keyboardSpeed = 10.0f;
    
    public float fireSpeed;
    public GameObject projectile;


    private bool mouseControl = true;
    public delegate void MovementDelegate();
    MovementDelegate movementMode; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //start with the mousemovement behavior
        movementMode = MouseMovement;
        StartCoroutine(SpawnProjectile());
    }

    // Update is called once per frame
    void Update()
    {
        movementMode();

        //garbage if nesting here
        if(Input.GetKeyDown(KeyCode.M)){
            if(mouseControl) {
                mouseControl = false;
                movementMode = KeyboardMovement;
            } else {
                mouseControl = true;
                movementMode = MouseMovement;
            }
        }



    }

    //stack overflow moment. but also reusing parts of my own code. heh
    IEnumerator SpawnProjectile()
    {
        while (true)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                //launch projectile
                Instantiate(projectile, transform.position,
                            projectile.transform.rotation);

                yield return new WaitForSeconds(fireSpeed);
            }

            yield return null;
        }
    }

    //"glues" the player to the mouse
    void MouseMovement() {
        //corrects the screen to world pos to infront of the cam
        Vector3 correctedPos = Camera.main.ScreenToWorldPoint(Input.mousePosition) 
                                + Vector3.forward;
        transform.position = correctedPos;
        

        //boundary checking is not neccisary here because if it goes out of bounds... it will
        //easily snap back to the mouse
    }

    void KeyboardMovement() {
        
        //grab inputs
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        Vector3 correctedPos = GameManager.Instance.playerCam.WorldToViewportPoint(
                                transform.position);
        float horizontalBound = GameManager.Instance.playerCam.ScreenToWorldPoint(Vector3.right).x;
        float verticalBound = GameManager.Instance.playerCam.ScreenToWorldPoint(Vector3.up).y;


        //bounds checking before moving
        if(0 < correctedPos.x && correctedPos.x < 1) {
            transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * keyboardSpeed);
        } else {
             transform.position = new Vector3(
                transform.position.x < 0 ? -horizontalBound : horizontalBound, 
                transform.position.y, transform.position.z);
        }

        if(0 < correctedPos.y && correctedPos.y < 1) {
            transform.Translate(Vector3.up * verticalInput * Time.deltaTime * keyboardSpeed);
        } else {
             transform.position = new Vector3(transform.position.x, 
             transform.position.y < 0 ? -verticalBound : verticalBound,
             transform.position.z);
        }

    }

}
