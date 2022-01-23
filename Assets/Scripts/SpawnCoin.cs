using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCoin : MonoBehaviour
{
    public GameObject CoinPrefab;
    public float startdelay = 2f;
    public float delay = 1.5f;
    private GameManager manager;
    public float xright = 1f;
    public float xleft = 3f;
    public float zposition = 4.7f;
    // Start is called before the first frame update
    void Start()
    {
        manager = GameObject.Find("GameManager").GetComponent<GameManager>();
        InvokeRepeating("StarSpawn", startdelay, delay);
    }

    // Update is called once per frame
    void Update()
    {


    }
    //coin spawning
    void StarSpawn()
    {
        if (manager.isgameover == false)
        {
            Vector3 position = new Vector3(Random.Range(-xleft, xright), 0, zposition);
            Instantiate(CoinPrefab, position, CoinPrefab.transform.rotation);
        }
    }
      
    
}