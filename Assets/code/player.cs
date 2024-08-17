using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public int health = 1;
    public float speed = 2f;
    public GameObject playerDeathVFX;
    private uimanager uimanager;
    // Start is called before the first frame update
    void Start()
    {
        uimanager = GameObject.Find("GameManager").GetComponent<uimanager>();
     
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePos = Input.mousePosition;
        Vector2 worldPos = Camera.main.ScreenToWorldPoint(mousePos);
        transform.position = Vector2.MoveTowards(transform.position, worldPos, speed * Time.deltaTime);
        
    }
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.transform.CompareTag("Enemy"))
        {
            health -= 1;
            if (health <= 0)
            {   
                Instantiate(playerDeathVFX, transform.position, transform.rotation);
                uimanager.OnGameFinish();
                Destroy(gameObject);
                Destroy(collider.gameObject);
            }
        }
    }
}
