using UnityEngine;
using System.Collections;

public class BreakFloor_Pieces : MonoBehaviour
{
    private float destroyTime = 10.0f;
    
    private void Start()
    {
        Destroy(gameObject, destroyTime);
    }
}
