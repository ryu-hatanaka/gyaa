using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Master : MonoBehaviour {
    [SerializeField] GameObject _player_go;
    [SerializeField] GameObject _henchman_manager;

    void Start( ) {
        _player_go.GetComponent<Player>( ).setup( );
        _henchman_manager.GetComponent<HenchmanManager>( ).setup( );
    }

    void Update( ) {
        if( _player_go != null ) {
            _player_go.GetComponent<Player>( ).update( );
            _henchman_manager.GetComponent<HenchmanManager>( ).update( );

        }
    }

}
