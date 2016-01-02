using UnityEngine;
using System.Collections;

public class BreakFloor : MonoBehaviour
{
    private Player _player;
    public GameObject BreakFloor_Parts;

    private float destroyTime = 0.05f;

    private void Start()
    {
        _player = FindObjectOfType<Player>();
    }

    //プレイヤーにぶつかったら壊れる
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player" && _player._playerMode == _player._PLAYER_MODE_ICE)
        {
            Destroy(gameObject, destroyTime);

            Instantiate(BreakFloor_Parts, new Vector3
                    (transform.position.x, transform.position.y,
                    transform.position.z), Quaternion.identity);
        }
    }
}
