using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeHUD : MonoBehaviour
{
    private GameObject[] hearts;
    private int lives = 3;
    public GameObject background;
    // Start is called before the first frame update
    void Start()
    {
        hearts = GameObject.FindGameObjectsWithTag("Heart");
    }

    public void HurtPlayer()
    {
        Debug.Log("OWIE ZOWIE;");
        lives -= 1;
        hearts[lives].SetActive(false);
        
        if (lives == 0)
        {
            background.GetComponent<GameManager>().GameOver();
        }
    }
}
