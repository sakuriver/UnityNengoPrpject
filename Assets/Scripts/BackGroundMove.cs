using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = this.transform.position;
        this.transform.position = new Vector3(pos.x, pos.y + 2.0f, pos.z);
        if (pos.y > 450)
        {
            this.transform.position = new Vector3(pos.x, -249.0f, pos.z);
        }

    }
}
