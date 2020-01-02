using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoneMove : MonoBehaviour
{

    bool isRight;
    // Start is called before the first frame update
    void Start()
    {
        isRight = true;
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = this.transform.position;
        if (isRight)
        {
            
            this.transform.position = new Vector3(pos.x + 0.1f, pos.y, pos.z);
            if (pos.x > 12) {
                isRight = false;
            }
        }
        else {
            this.transform.position = new Vector3(pos.x - 0.1f, pos.y, pos.z);
            if (pos.x < -12) {
                isRight = true;
            }
        }
    }
}
