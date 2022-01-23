using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;
    public int  xboundary=4;
    private GameManager manager;
    // Start is called before the first frame update
    void Start()
    {
        manager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        //Set boundary of player
        if (transform.position.x < -xboundary)
        {
            transform.position = new Vector3(-xboundary, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xboundary)
        {
            transform.position = new Vector3(xboundary, transform.position.y, transform.position.z);
        }
        //player move right left with arrow keys
        float horizontalInput = Input.GetAxis("Horizontal");
     transform.Translate (Vector3.right * Time.deltaTime * speed* horizontalInput);

    }
    //player collision results
    private void OnCollisionEnter(Collision collision)
    {
       if (collision.gameObject.CompareTag("Obstacle"))
        {
            manager.AddLives(-1);
        }
       if(collision.gameObject.CompareTag("Coin"))
        {
            manager.AddScore(1);
            Destroy(collision.gameObject);
        }
            
    }
}
