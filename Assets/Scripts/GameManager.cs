using UnityEngine;


public class GameManager : MonoBehaviour
{
    public GameObject enemy;
    public int enemyCount;
    public float playableSpace = 0.9f;
    public Camera playerCam;
    public static GameManager Instance;

    public int score = 0;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

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
        
        float x = playableSpace;
        float y = playableSpace; 

        //get the raw random number
        Vector3 correctedPos = new Vector3(Random.Range(0, x), Random.Range(0, y), 1);

        //center it
        Debug.Log(correctedPos);
        correctedPos += new Vector3((1 - playableSpace) /2, (1 - playableSpace) /2, 0);
        correctedPos = playerCam.ViewportToWorldPoint(correctedPos);
        Debug.Log(correctedPos);

        //correctedPos.x *= playableSpace;
        //correctedPos.y *= playableSpace;

        Instantiate(enemy, correctedPos + transform.position, Quaternion.identity);

        return;
    }


}
