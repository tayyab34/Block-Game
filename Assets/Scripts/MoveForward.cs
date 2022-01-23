using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    
    public float speed = 5.0f;
    private GameManager manager;
    private float lowerbound = 7f;
    // Start is called before the first frame update
    void Start()
    {
        manager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        //Destroy object at this bound
        if (transform.position.z < -lowerbound)
        {
            Destroy(gameObject);
        }
        //Obstacle and coin movement
        if (manager.isgameover == false)
        {
            transform.Translate(Vector3.back * Time.deltaTime * speed);
        }
      
    }
}
