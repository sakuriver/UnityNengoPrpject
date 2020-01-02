using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReiwaMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    [System.Obsolete]
    void Update()
    {
        Vector3 pos = this.transform.position; 

        this.transform.position = new Vector3(pos.x, pos.y + 1.0f, pos.z);
        if (pos.y > 322) {
            Destroy(this);
        }
        
    }
}
