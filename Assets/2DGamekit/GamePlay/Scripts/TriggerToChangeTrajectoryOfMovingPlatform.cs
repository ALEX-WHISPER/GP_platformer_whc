using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Gamekit2D;

public class TriggerToChangeTrajectoryOfMovingPlatform : MonoBehaviour {
    public List<Transform> nodes;
    public MovingPlatform tarMovingPlatform;

    public void SetNewTrajectoryToMovingPlatform() {
        tarMovingPlatform.StopMoving();

        Vector3[] newWorldNodes = new Vector3[nodes.Count];
        for (int i = 0; i < newWorldNodes.Length; i++) {
            newWorldNodes[i] = nodes[i].position;
        }
        tarMovingPlatform.SetNewNodes(newWorldNodes);
    }
}
