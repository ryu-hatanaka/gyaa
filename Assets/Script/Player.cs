using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.AI;


public class Player : Mother {
    private Rigidbody rb;
    public void setup( ) {
        rb = this.GetComponent<Rigidbody>( );
        initCreateHenchman( );
    }
    public void update( ) {
        Debug.Log( _henchman_list );
        move( );
    }

    private void move( ) {
        MoveToKey( );
    }

    private void MoveToKey( ) {
        float horizontal = Input.GetAxisRaw( "Horizontal" ); //A、D、←、→
        float vertical = Input.GetAxisRaw( "Vertical" );　   //W、S、↑、↓
        float speed = COMMON.VAR.PLAYER_SPEED;
        Vector3 vec = new Vector3( horizontal * speed, 0.0f, vertical * speed );
        rb.velocity = vec;
    }

    private void initCreateHenchman( ) {
        addHenchman( );
    }
}

