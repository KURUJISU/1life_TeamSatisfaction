using UnityEngine;
using System.Collections;

public class Stone_Trap : MonoBehaviour
{
    [SerializeField]
    private GameObject _firstStone;
    [SerializeField]
    private Vector3 _fStonePos = new Vector3(10, 30, 0);
    [SerializeField]
    private GameObject _secondStone;
    [SerializeField]
    private Vector3 _sStonePos = new Vector3(15, 30, 0);
    [SerializeField]
    private GameObject _bigStone;
    [SerializeField]
    private Vector3 _bStonePos = new Vector3(20, 30, 0);

    private bool _trap = false;
    private int _sponeCount = 0;
    private int _sponeTime = 15 * 60;

    private GameObject CreateStone(GameObject origin, Vector3 pos)
    {
        var gameObject = Instantiate(origin);
        gameObject.transform.Translate(pos);
        return gameObject;
    }

    private void Update()
    {
        if (_trap)
        {
            if (_sponeCount <= 0)
            {
                CreateStone(_firstStone, _fStonePos);
                CreateStone(_secondStone, _sStonePos);
            }
            else if (_sponeCount >= _sponeTime && _sponeCount <= _sponeTime + 0.5f)
            {
                CreateStone(_bigStone, _bStonePos);
            }

            _sponeCount++;
        }
    }

    private void OnTriggerEnter()
    {
        _trap = true;
    }
}
