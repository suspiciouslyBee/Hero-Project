using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float health = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(health < 0){
            Destroy(gameObject);
        }
    }
}
