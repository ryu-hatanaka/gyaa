using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HenchmanManager : MonoBehaviour {
    [SerializeField] private GameObject _henchman_prefab;

    private List<GameObject> _henchman_list = new List<GameObject>( );

    public void setup( ) {
        //デバッグ
        for( int i = 0; i < 4; i++ ) {
            createHenchman( );
        }
    }

    public void update( ) {
        foreach( GameObject go in _henchman_list ) {
            go.GetComponent<Henchman>( ).update( );
        }
    }

    private void createHenchman( ) {
        GameObject go = Instantiate( _henchman_prefab );
        _henchman_list.Add( go );
        go.GetComponent<Henchman>( ).setup( go, _henchman_list.Count );
    }
}
