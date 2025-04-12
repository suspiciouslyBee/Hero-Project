using System;
using UnityEngine;                                                                                           

public class Enemy : MonoBehaviour
{
    public float health = 1;
    public float maxHealth = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        UpdateColor();


        if (health <= 0)
        {
            //garbage, but this will do

            GameManager.Instance.SpawnEnemySomewhere();

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

    public void ChangeHealth(float sumOrDifference)
    {
        health += sumOrDifference;
    }

    internal float GetMaxHealth()
    {
        return maxHealth;
    }
}
