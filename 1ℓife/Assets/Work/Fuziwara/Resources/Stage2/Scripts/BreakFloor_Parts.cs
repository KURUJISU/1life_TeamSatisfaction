using UnityEngine;
using System.Collections;

public class BreakFloor_Parts : MonoBehaviour {

    public GameObject BreakFloor_Pieces;
    
    //床にぶつかったら当たり判定ない物に変更
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            Instantiate(BreakFloor_Pieces, new Vector3
                    (transform.position.x, transform.position.y,
                    transform.position.z), Quaternion.identity);

            Destroy(gameObject);
        }
    }
}
