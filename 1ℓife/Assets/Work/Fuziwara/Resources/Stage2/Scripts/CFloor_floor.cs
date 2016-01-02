using UnityEngine;
using System.Collections;

public class CFloor_floor : MonoBehaviour
{
    private CFloor_roof _roof;

    private bool _onFloor = false;
    public bool OnFloor { get { return _onFloor; } }

    [SerializeField]
    private float _moveFloorValue = 0.01f;

    private void Start()
    {
        _roof = FindObjectOfType<CFloor_roof>();
    }

    private void Update()
    {
        if (_onFloor && _roof.MoveRoof)
        {
            transform.Translate(0.0f, -1 * _moveFloorValue, 0.0f);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            _onFloor = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            _onFloor = false;
        }
    }
}
