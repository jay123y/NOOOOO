using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class uimanager : MonoBehaviour
{
    public TextMeshProUGUI killText;
    public TextMeshProUGUI coinText;
    public GameObject gameOver;
    private playermanager playerManager;
    // Start is called before the first frame update
    void Start()
    {
        playerManager = GetComponent<playermanager>();
        gameOver.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnGameFinish()
    {
        killText.text = playerManager.kill.ToString();
        gameOver.SetActive(true);
    }
    public void OnRetryPressed(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void OnGoBackPressed() {
        SceneManager.LoadScene(0);

    } 

}
