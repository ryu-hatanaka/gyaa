using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mother : MonoBehaviour{
    protected List<GameObject> _henchman_list = new List<GameObject>( );
    public void createHenchman( ){
        GameObject prefab = ( GameObject )Resources.Load( "Henchman" );
        GameObject go = Instantiate( prefab );
        _henchman_list.Add( go );
    }
}
