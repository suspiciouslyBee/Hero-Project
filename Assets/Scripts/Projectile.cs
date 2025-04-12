using UnityEngine;

public class Projectile: MonoBehaviour
{
    public float speed;

    
    //for the assignment its manually set to 20% of the fighter hp, wanted modular for different
    ///types of projectiles
    public float damage;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        FrameMotion();
    }

    //override with a child class to change the behavior
    //base class is a simple move forward
    void FrameMotion()
    {
        transform.Translate(Vector3.up * Time.deltaTime * speed);
    }

}
