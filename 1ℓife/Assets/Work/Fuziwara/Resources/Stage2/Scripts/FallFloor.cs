using UnityEngine;
using System.Collections;

public class FallFloor : MonoBehaviour
{
    private Rigidbody _rigidbody;
    private bool _fallDown = false;
	
    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

	private void Update ()
    {
	    if(_fallDown)
        {
            _rigidbody.constraints = RigidbodyConstraints.None;
        }
	}

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag=="Player")
        {
            _fallDown = true;
        }
    }
}
