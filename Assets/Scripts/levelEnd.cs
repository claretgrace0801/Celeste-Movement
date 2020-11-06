using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelEnd : MonoBehaviour
{
    private int level;
    public Transform player;
    public Transform cam;
    public Transform[] playerPos = new Transform[4];
    public Transform[] camPos = new Transform[4];

    // Start is called before the first frame update
    void Start()
    {
        level = 1;
        player.position = playerPos[level-1].position;
        cam.position = camPos[level-1].position;
    }

    // Update is called once per frame
    // void Update()
    // {
        
    // }
    private void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log("Level end");
        if(level < 4)
        {
            level++;
            player.position = playerPos[level-1].position;
            cam.position = camPos[level-1].position;
        } 
        else
        {
            Debug.Log("You won");
        }  

    }
}
