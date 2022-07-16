using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.AI;

public class Player : Mother {
    private Rigidbody rb;

    public void setup( ) {
        rb = this.gameObject.GetComponent<Rigidbody>( );
    }
    public void update( ) {
        move( );
    }

    private void move( ) {
        MoveToKey( );
    }

    private void MoveToKey( ) {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
       
        float speed = COMMON.VAR.PLAYER_SPEED;
        Vector3 vec = new Vector3(horizontal * speed, 0.0f, vertical * speed);
        rb.velocity = vec;
    }
}