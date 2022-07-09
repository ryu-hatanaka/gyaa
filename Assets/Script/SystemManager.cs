using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemManager : MonoBehaviour
{
    [ SerializeField ] GameObject _player_obj;
    // Start is called before the first frame update
    void Start( ){
        if( _player_obj != null ){
            _player_obj.GetComponent< Player >( ).update( );
        }
    }

    // Update is called once per frame
    void Update( ){
        
    }
}
