using UnityEngine;

public class DamageEnemyOnHit : MonoBehaviour
{
    public float damage;
    public bool instantKill;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log("Hit Something");


        if (other.CompareTag("Enemy"))
        {

            //Debug.Log("Hit Enemy");
            Enemy subject = other.GetComponent<Enemy>();
            subject.ChangeHealth(-damage);

            //instakill support
            //yes that does mean that instakills run the command twice. but i feel this is more
            //readable... for now
            if (instantKill)
            {
                subject.ChangeHealth(-subject.GetMaxHealth());
            }
        }
    }
}
