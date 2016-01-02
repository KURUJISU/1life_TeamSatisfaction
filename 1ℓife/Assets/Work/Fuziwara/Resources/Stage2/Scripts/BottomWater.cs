using UnityEngine;
using System.Collections;

public class BottomWater : MonoBehaviour
{
    private float _angle = 0.0f;
    [SerializeField]
    private float _wave = 0.0f;

    void Update()
    {
        _angle += 0.05f;
        transform.Translate(0.0f, Mathf.Sin(_angle) * _wave, 0.0f);
    }
}
