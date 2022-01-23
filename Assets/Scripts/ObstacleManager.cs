using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleManager : MonoBehaviour
{
    public GameObject[] obstaclePrefab;
    private GameManager manager;
    public float startdelay = 2;
    public float delay = 2.5f;
    public float xright = 1f;
    public float xleft = 3f;
    public float zposition = 4.7f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("ObstacleRepeat", startdelay, delay);
    }

    // Update is called once per frame
    void Update()
    {
        manager = GameObject.Find("GameManager").GetComponent<GameManager>();

    }
    //Obstacle spawning
    public void ObstacleRepeat()
    {
        if (manager.isgameover == false)
        {
            int spawnobstacle = Random.Range(0, obstaclePrefab.Length);
            Vector3 position = new Vector3(Random.Range(-xleft, xright), 1, zposition);
            Instantiate(obstaclePrefab[spawnobstacle], position,
            obstaclePrefab[spawnobstacle].transform.rotation);
        }
        
    }
    
}
