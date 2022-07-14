using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Master : MonoBehaviour {
    [SerializeField] GameObject _player_go;

    void Start( ) {
        _player_go.GetComponent<Player>( ).setup( );
    }

    void Update( ) {
        if( _player_go != null ) {
            _player_go.GetComponent<Player>( ).update( );
        }
    }

}
