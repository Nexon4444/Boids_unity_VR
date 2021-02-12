using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Flock/Behavior/Cohesion")]
public class CohesionBehavior : FlockBehavior
{
    public override Vector2 CalculateMove(Agent agent, List<Transform> context, Flock flock)
    {
        //if no neighbors, return no adjustment
        if (context.Count == 0)
            return Vector2.zero;

        //add all points together and average
        Vector2 cohesionMove = Vector2.zero;
        // List<Transform> filteredContext = (filter == null) ? context : filter.Filter(agent, context);
        List<Transform> filteredContext = context;
        foreach (Transform item in filteredContext)
        {
            cohesionMove += (Vector2)item.position;
        }
        cohesionMove /= context.Count;

        //create offset from agent position
        cohesionMove -= (Vector2)agent.transform.position;
        return cohesionMove;
    }
    public Vector2 CalculateMove(ObstacleAgent agent, List<Transform> context, Flock flock)
    {
        return Vector2.zero;
    }
}
