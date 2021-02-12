using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class FlockBehavior : ScriptableObject
{
    public abstract Vector2 CalculateMove(Agent agent, List<Transform> context, Flock flock);
    // public abstract Vector2 CalculateMove(ObstacleAgent agent, List<Transform> context, Flock flock);
}
