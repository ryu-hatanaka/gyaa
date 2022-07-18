using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mother : MonoBehaviour{
    protected List<GameObject> _henchman_list = new List<GameObject>( );
    public void addHenchman( ){
        GameObject prefab = ( GameObject )Resources.Load( "Henchman" );
        GameObject go = Instantiate( prefab );
        go.transform.position = this.transform.position + new Vector3( 0.0f, 0.0f, 0.0f ); //testÉRÅ[Éh
        _henchman_list.Add( go );
    }
}
