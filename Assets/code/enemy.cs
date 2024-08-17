using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public int health = 1;
    public int killPoints = 1;
    public bool canTouch = true;
    private playermanager playermanager;
    private uimanager uiManager;
    public GameObject bulletHitVFX;
    // Start is called before the first frame update
    void Start()
    {
        playermanager = GameObject.Find("GameManager").GetComponent<playermanager>();
        uiManager = GameObject.Find("GameManager").GetComponent<uimanager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.transform.CompareTag("Bullet") && canTouch)
        {
            OnHit(collision.gameObject);
        }
        
    }
    public void OnHit(GameObject hit)
    {
        health -= 1;
        if (health <= 0)
        {
            Instantiate(bulletHitVFX, transform.position, transform.rotation);
            Destroy(gameObject);
            playermanager.updatekill(killPoints);
        }
    Destroy(hit);
    }
        // Update is called once per frame
        void Update()
    {
        
    }
}
