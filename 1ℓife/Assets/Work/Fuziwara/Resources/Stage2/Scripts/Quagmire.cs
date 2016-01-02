using UnityEngine;
using System.Collections;

public class Quagmire : MonoBehaviour
{
    private Player _player;
    private float _jumpPower = 0;

    private void Start()
    {
        _player = FindObjectOfType<Player>();
        _jumpPower = _player.Jump_Power;
    }

    private void OnTriggerEnter()
    {
        _player.Jump_Power = _jumpPower / 2;
    }

    private void OnTriggerExit()
    {
        _player.Jump_Power = _jumpPower;
    }
}
