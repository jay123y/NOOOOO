using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunshootTlqkf : MonoBehaviour
{
    public GameObject bullet;
    private GameObject shootpoint;
    public float delay = 0f;
    public float delayDefault = 2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        delay -= Time.deltaTime;
        if(Input.GetMouseButtonDown(0) && delay <= 0){
            delay = delayDefault;
            Instantiate(bullet, transform.position,transform.rotation);
        }
    }
}
