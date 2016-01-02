using UnityEngine;
using System.Collections;

public class Snow : MonoBehaviour
{
    private Player _player;
    
    private void Start()
    {
        _player = FindObjectOfType<Player>();
    }

    private void OnTriggerEnter()
    {
        if (_player._playerMode == _player._PLAYER_MODE_WATER)
        {
            _player._playerMode = _player._PLAYER_MODE_ICE;
        }
    }
}
