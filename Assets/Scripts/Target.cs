using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour

{
    
    private float minSpeed = 12;
    private float maxSpeed = 16;
    private float maxTorque = 10;
    private float xRange = 4;
    private float ySpawnPos = -6;
    private Rigidbody targetRb;
    private GameManager gameManager;

    void Start()
    {
        gameManager = GameObject.Find("Game Manager")
             .GetComponent<GameManager>();}

    private void OnMouseDown() {
        gameManager.UpdateScore(5); 

    private void OnTriggerEnter(Collider other) {
        Destroy(gameObject); }

    

    void Update()
    {
        
    }
}
