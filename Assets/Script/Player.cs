using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Mother {
    private Rigidbody rb;
    private GameObject this_obj;

    public Player( GameObject this_obj ){
        this.this_obj = this_obj;
        rb = this_obj.GetComponent< Rigidbody >( );
    }
    public void update( ){
        move( );
    }

    private void move( ){
        const float SPEED = 5.0f;
        Vector3 vec = new Vector3( 0, 0, 0 );
        if ( Input.GetKey( KeyCode.W ) || Input.GetKey( KeyCode.UpArrow ) ){
            vec += new Vector3( 0, 0, SPEED );
        }
        if ( Input.GetKey( KeyCode.S ) || Input.GetKey( KeyCode.DownArrow ) ){
            vec += new Vector3( 0, 0, -SPEED );
        }
        if ( Input.GetKey( KeyCode.A ) || Input.GetKey( KeyCode.LeftArrow ) ){
            vec += new Vector3( -SPEED, 0, 0 );
        }
        if ( Input.GetKey( KeyCode.D ) || Input.GetKey( KeyCode.RightArrow ) ){
            vec += new Vector3( SPEED, 0, 0 );
        }
        rb.velocity = vec;
    }
}
