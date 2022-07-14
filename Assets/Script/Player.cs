using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Player : Mother {
    private Rigidbody rb;
    private GameObject _go;

    public void setup( ) {
        createMother( );
        rb = _go.GetComponent< Rigidbody >( );
    }
    public void update( ) {
        move( );
    }

    //createという名前であるが子オブジェクトを参照しているだけである
    private void createMother( ) {
        _go = transform.Find( "Mother" ).gameObject;
    }

    private void move( ) {
        float horizontal = Input.GetAxisRaw( "Horizontal" );
        float vertical = Input.GetAxisRaw( "Vertical" );
        float speed = COMMON.VAR.PLAYER_SPEED;
        Vector3 vec = new Vector3( horizontal * speed, 0.0f, vertical * speed );
        rb.velocity = vec;
    }
}
