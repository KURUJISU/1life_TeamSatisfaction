using UnityEngine;
using System.Collections;

public class CFloor_roof : MonoBehaviour
{
    private CFloor_floor _floor;

    private bool _moveRoof = false;
    public bool MoveRoof { get { return _moveRoof; } }

    [SerializeField, Range(0.5f, 0.0f)]
    private float _roofRatateLimit = 0.3f;

    private void Start()
    {
        _floor = FindObjectOfType<CFloor_floor>();
    }

    private void Update()
    {
        if (_floor.OnFloor && transform.rotation.z <= _roofRatateLimit)
        {
            _moveRoof = true;
            transform.Rotate(0.0f, 0.0f, 0.1f);
        }
        else _moveRoof = false;
    }
}
