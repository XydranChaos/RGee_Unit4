﻿using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Rigidbody enemyRB;
    GameObject player;
    public float speed = 4.0f;
    void Start()
    {
        player = GameObject.Find("Player");
        enemyRB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //enemy will have a distance between the player when chasing.
        Vector3 seekDirection = (player.transform.position - transform.position).normalized;
        enemyRB.AddForce( seekDirection * speed * Time.deltaTime);
    }
}
