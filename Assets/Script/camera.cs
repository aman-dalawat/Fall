using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public Transform playerTransform;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       Vector3 cameraPos = transform.position;
       cameraPos.y = playerTransform.position.y;
       transform.position = cameraPos;
    }
}
