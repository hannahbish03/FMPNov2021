using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimFix : MonoBehaviour
{
    public Transform mainPos;
    public PlayerMovement playerMoveScript;
    void Update()
    {
        transform.position = mainPos.position;
    }
}
