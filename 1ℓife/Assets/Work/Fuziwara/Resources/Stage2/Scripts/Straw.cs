using UnityEngine;
using System.Collections;

public class Straw : MonoBehaviour {

    private Rigidbody _rigidbody;

	void Start ()
    {
        _rigidbody = GetComponent<Rigidbody>();
	}
	
	void Update ()
    {
        _rigidbody.AddForce(new Vector3(0, -100000, 0), ForceMode.Force);
	}
}
