﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Flock/Behavior/Alignment")]
public class AlignmentBehavior : FlockBehavior
{
    public override Vector2 CalculateMove(Agent agent, List<Transform> context, Flock flock)
    {
        //if no neighbors, maintain current alignment
        if (context.Count == 0)
            return agent.transform.up;

        //add all points together and average
        Vector2 alignmentMove = Vector2.zero;
        // List<Transform> filteredContext = (filter == null) ? context : filter.Filter(agent, context);
        List<Transform> filteredContext = context;
        foreach (Transform item in filteredContext)
        {
            alignmentMove += (Vector2)item.transform.up;
        }
        alignmentMove /= context.Count;

        return alignmentMove;
    }
    public Vector2 CalculateMove(ObstacleAgent agent, List<Transform> context, Flock flock)
    {
        return Vector2.zero;
    }
}
