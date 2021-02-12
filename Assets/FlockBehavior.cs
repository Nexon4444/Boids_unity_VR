using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface FlockBehavior<T> {
    Vector2 CalculateMove(T agent, List<Transform> context, Flock flock);
    // public abstract Vector2 CalculateMove(ObstacleAgent agent, List<Transform> context, Flock flock);
}
