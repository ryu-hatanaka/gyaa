using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HenchmanManager : MonoBehaviour {


    [SerializeField] private GameObject _henchman_prefab;

    private List<GameObject> _all_henchman_list = new List<GameObject>( );

    public void setup( ) {
        //�f�o�b�O
        for( int i = 0; i < 4; i++ ) {
            createHenchman( );
        }
    }

    public void update( ) {
        foreach( GameObject go in _all_henchman_list ) {
            go.GetComponent<Henchman>( ).update( );
        }
    }

    private void createHenchman( ) {
        GameObject henchman_go = Instantiate( _henchman_prefab );
        _all_henchman_list.Add( henchman_go );
        henchman_go.GetComponent<Henchman>( ).setup( henchman_go, _all_henchman_list.Count );
    }
}
