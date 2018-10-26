﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseSteeringBehaviour : SteeringBehaviour
{

    public float anticipationMultiplier;
    public float maxSpeed = 4f;

    private Rigidbody rb;
    private Transform trans;
    private CharacterController ccPlayer;
    private CharacterController ccEnemy;
    private Vector3 startPos;
    private Vector3[] path;
    private Vector3 destination;
    private int pathIndex;
    float timer;


    void Start()
    {
        //buscar el player singleton
        //ccPlayer = player.GetComponent<CharacterController>();
        ccEnemy = GetComponent<CharacterController>();

    }
    public override void Act()
    {
        //use pathfinding of unity
        return;
    }

    public void Pursuit()
    {

        if (path != null)
        {
            /*Vector3 toEvader = base.player.position - trans.position;

            float relativeHeading = Vector3.Dot(base.player.transform.forward, trans.forward);

            float lookAheadTime = toEvader.magnitude / (maxSpeed + ccPlayer.velocity.magnitude);

            Debug.Log(base.player.velocity);
            Debug.DrawLine(trans.position, trans.position + ccPlayer.velocity * 50, Color.red);

            ccEnemy.Move(((destination + controller.velocity * (lookAheadTime * anticipationMultiplier)) - trans.position).normalized * maxSpeed * Time.deltaTime);

            if(Vector3.Distance(trans.position, destination) < ccPlayer.radius * 2)
            {
                pathIndex++;
            }
            */
            //ccEnemy.Move((ccPlayer.transform.position - trans.position).normalized * maxSpeed * Time.deltaTime);
        }
    }

}