using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Levels_Manager : MonoBehaviour
{
    public static Levels_Manager instance = null;
    public GameObject PlayerPrefab;
    public GameObject player;
    public static int lifes = 3;

    // Start is called before the first frame update
    void Start()
    {
        if (instance == null) 
        {
            DontDestroyOnLoad(gameObject);
            instance= this;
            player = Instantiate(PlayerPrefab);
            DontDestroyOnLoad(player);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public static void LoseLife(){
        lifes--;
        print(lifes);
        if (lifes <=0)
        {
            SceneManager.LoadScene("GAMEOVER");
        }
        else 
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
