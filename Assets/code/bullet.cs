using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    private float screenSize;
    // Start is called before the first frame update
    void Start()
    {
        screenSize = Camera.main.orthographicSize;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < - screenSize || transform.position.y > screenSize)
        {
            Destroy(gameObject);
        }
    }
}
