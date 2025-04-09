using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject enemy;
    public int enemyCount;
    public float playableSpace = 0.9f;
    public Camera playerCam;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for(int i = 0; i < enemyCount; i++) {
            SpawnEnemySomewhere();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnEnemySomewhere(){

        //get the ranges by getting the playspace, then halving it to get one half of each axis
        //range
        float x = (Screen.width * playableSpace);
        float y = (Screen.height * playableSpace);

        


        Instantiate(enemy, playerCam.ScreenToWorldPoint(new Vector3(Random.Range(0, x),
                                                         Random.Range(0, y), 1))
                            , Quaternion.identity);

        return;
    }
}
