using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Flock/Behavior/Stay In Radius")]
public class StayInRadiusBehavior : FlockBehavior
{
    public Vector2 center;
    public float radius = 15f;

    public override Vector2 CalculateMove(Agent agent, List<Transform> context, Flock flock)
    {
        Vector2 centerOffset = center - (Vector2)agent.transform.position;
        float t = centerOffset.magnitude / radius;
        if (t < 0.9f)
        {
            return Vector2.zero;
        }

        return centerOffset * t * t;
    }
    public Vector2 CalculateMove(ObstacleAgent agent, List<Transform> context, Flock flock)
    {
        return Vector2.zero;
    }
}
