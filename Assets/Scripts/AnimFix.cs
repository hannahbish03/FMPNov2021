using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimFix : MonoBehaviour
{
    public Transform mainPos;

    void Update()
    {
        transform.position = mainPos.position;
    }
}
