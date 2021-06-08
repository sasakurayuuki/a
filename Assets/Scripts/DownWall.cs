using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownWall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            Destroy(collision.gameObject);
            PlayerController.ballExistFlag = false;
        }
    }
}
