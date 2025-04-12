using UnityEngine;                                                                                           

public class Enemy : MonoBehaviour
{
    private float health = 1;
    private float maxHealth = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        UpdateColor();


        if (health < 0)
        {
            Destroy(gameObject);
        }
        
    }

    private void UpdateColor()
    {
        //alpha is a percentage
        float normalizedAlpha = Mathf.Clamp((health / maxHealth) * 100, 0, 100);

        //cant edit alpha directly must copy it temporarally
        Color hopper = gameObject.GetComponent<SpriteRenderer>().color;

        hopper.a = normalizedAlpha;

        gameObject.GetComponent<SpriteRenderer>().color = hopper;
    }
}
