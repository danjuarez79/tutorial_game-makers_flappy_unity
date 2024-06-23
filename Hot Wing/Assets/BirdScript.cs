using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public LogicManagerScript logicManagerScript;
    public bool birdIsAlive = true;
    // public bool birdIsAlive { get; private set; }

    // Start is called before the first frame update
    void Start()
    {
        logicManagerScript = GameObject.FindGameObjectWithTag("LogicManagerTag").GetComponent<LogicManagerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && birdIsAlive) {
            myRigidbody.velocity = Vector2.up * flapStrength;
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        logicManagerScript.gameOver();
        birdIsAlive = false;
    }
}
