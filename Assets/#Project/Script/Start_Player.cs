using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start_Player : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        Levels_Manager levelsManager = Levels_Manager.instance;
        GameObject player = levelsManager.player;
        player.transform.position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
