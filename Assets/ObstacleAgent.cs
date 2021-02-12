using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class ObstacleAgent : Agent
{
    void Start()
    {
        agentCollider = GetComponent<Collider2D>();
        agentCollider.gameObject.tag = "ObstacleAgent";
    }
    
    override public void Move(Vector2 velocity)
    {}
    //     transform.up = velocity;
    //     transform.position += (Vector3)velocity * Time.deltaTime;
    // }
}