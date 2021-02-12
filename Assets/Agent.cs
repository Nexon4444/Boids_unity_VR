using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public abstract class Agent : MonoBehaviour
{

    protected Flock agentFlock;
    public Flock AgentFlock { get { return agentFlock; } }

    protected Collider2D agentCollider;
    public Collider2D AgentCollider { get { return agentCollider; } }

    // Start is called before the first frame update


    public void Initialize(Flock flock)
    {
        agentFlock = flock;
    }

    public abstract void Move(Vector2 velocity);
}
