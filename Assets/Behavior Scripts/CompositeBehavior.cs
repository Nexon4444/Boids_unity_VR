using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct BehaviorStruct{
        public FlockBehavior behavior;
        public float weight;

    }

[CreateAssetMenu(menuName = "Flock/Behavior/Composite")]
public class CompositeBehavior : FlockBehavior<FlockAgent>
{
    public BehaviorStruct[] behaviorStructs;
    
    public override Vector2 CalculateMove(FlockAgent agent, List<Transform> context, Flock flock)
    {

    //     //set up move
        Vector2 move = Vector2.zero;


        //iterate through behaviors
        foreach (BehaviorStruct behaviorStruct in this.behaviorStructs)
        {
            Vector2 partialMove = behaviorStruct.behavior.CalculateMove(agent, context, flock) * behaviorStruct.weight;

            if (partialMove != Vector2.zero)
            {
                if (partialMove.sqrMagnitude >  behaviorStruct.weight * behaviorStruct.weight)
                {
                    partialMove.Normalize();
                    partialMove *=  behaviorStruct.weight;
                }
                move += partialMove;
            }
        }
        return move;
    }
    public override Vector2 CalculateMove(ObstacleAgent agent, List<Transform> context, Flock flock)
    {
        return Vector2.zero;
    }
}
