using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levels_Manager : MonoBehaviour
{
    public static Levels_Manager instance = null;
    public GameObject PlayerPrefab;
    public GameObject player;

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

    // Update is called once per frame
    void Update()
    {
        
    }
}
