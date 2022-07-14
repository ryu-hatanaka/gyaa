using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HenchmanManager : MonoBehaviour {
    [SerializeField] private GameObject _henchman_prefab;
    
    private List<GameObject> _henchman_list = new List< GameObject >( );
    
    public void setup( ){
        //�f�o�b�O
        createHenchman( );

    }

    public void update( ) {
        
    }

    private void createHenchman( ) {
        GameObject go = Instantiate( _henchman_prefab );
        _henchman_list.Add( go );
        go.GetComponent< Henchman >( ).setup( go, _henchman_list.Count );
    }
}
