using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIHandler : MonoBehaviour
{
    public TextMeshProUGUI statusText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //TODO: this feels jank.

        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        GameObject[] eggs = GameObject.FindGameObjectsWithTag("Projectile");

        statusText.text = "Hero Mode | # Eggs:" + eggs.Length +
                            " | # Enemies:" + enemies.Length +
                            " | # Kills:" + GameManager.Instance.score;

        




    }
}
