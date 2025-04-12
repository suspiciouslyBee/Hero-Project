using UnityEngine;

public class Projectile: MonoBehaviour
{
    public float speed;
    //public float damage;
    
    //for the assignment its manually set to 20% of the fighter hp, wanted modular for different
    //types of projectiles

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //gameObject.GetComponent<DamageEnemyOnHit>().damage = damage;
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
