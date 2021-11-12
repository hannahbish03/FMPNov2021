
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

   [SerializeField] Transform Player;
    Vector3 offset;

    
    
    private void Start()
    {
        offset = transform.position - Player.position; 
   
    }

    
    private void Update()
    {
       Vector3 targetPos = Player.position + offset;
        targetPos.x = 0;
        transform.position = targetPos;
    }
}
