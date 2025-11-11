using System.Collections;
using System.Collections.Generic;
using Unity.FPS.Game;
using Unity.FPS.Gameplay;
using UnityEditor.Build.Content;
using UnityEngine;

public class Cookie : MonoBehaviour
{
    private GameFlowManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameFlowManager>();
        Destroy(gameObject, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider whatDidIHit)
    {
        if (whatDidIHit.tag == "Player")
        {
            gameManager.IncreaseScore();
            Destroy(gameObject);
        }
    }
}
