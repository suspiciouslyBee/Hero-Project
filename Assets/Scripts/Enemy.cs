using NUnit.Framework.Internal.Commands;
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

        
        //thanks to how floats are done, need to cut off some floor here
        if (Math.Round(health, 2) <= 0)
        {
            //garbage, but this will do

            GameManager.Instance.SpawnEnemySomewhere();

            Destroy(gameObject);
        }
        
    }

    private void UpdateColor()
    {
        //alpha is a percentage
        

        //cant edit alpha directly must copy it temporarally
        Color hopper = gameObject.GetComponent<SpriteRenderer>().color;

        hopper.a = OpacityFunction();

        gameObject.GetComponent<SpriteRenderer>().color = hopper;
    }

    public void ChangeHealth(float sumOrDifference)
    {
        health += sumOrDifference;
        //Debug.Log(health);
    }

    //should be equivalent to reducing to 80% of current opacity per 20% damage
    private float OpacityFunction()
    {
        //get health ratio/percentage, normalized
        float normalizedRatio = Mathf.Clamp(health / maxHealth, 0, 1);

        //thank god i know how to do desmos, i didnt want to do math today
        //probably not an exact number, but i dont think the player will be able to tell
        //if the model is like off by 0.0001 or something

        return Mathf.Pow(3.05176f, normalizedRatio - 1);
    }

    internal float GetMaxHealth()
    {
        return maxHealth;
    }
}
