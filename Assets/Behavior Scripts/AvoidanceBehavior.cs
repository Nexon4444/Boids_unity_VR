using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Flock/Behavior/AvoidanceBehavior")]
public class AvoidanceBehavior : FlockBehavior
{
    public override Vector2 CalculateMove(Agent agent, List<Transform> context, Flock flock)
    {
        //if no neighbors, return no adjustment\
         
        if ((context.Count == 0) || (agent is ObstacleAgent))
            return Vector2.zero;

        //add all points together and average
        Vector2 avoidanceMove = Vector2.zero;
        int nAvoid = 0;
        // List<Transform> filteredContext = (filter == null) ? context : filter.Filter(agent, context);
        List<Transform> filteredContext = context;
        foreach (Transform item in filteredContext)
        {
            if (Vector2.SqrMagnitude(item.position - agent.transform.position) < flock.SquareAvoidanceRadius)
            {
                nAvoid++;
                avoidanceMove += (Vector2)(agent.transform.position - item.position);
            }
        }
        if (nAvoid > 0)
            avoidanceMove /= nAvoid;

        return avoidanceMove;
    }

    // public Vector2 CalculateMove(ObstacleAgent agent, List<Transform> context, Flock flock)
    // {
    //     return Vector2.zero;
    // }
}
