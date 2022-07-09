using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Henchman {
    public int _id;
    public GameObject _obj;
    public GameObject _mother_obj;

    public Henchman( int id, GameObject obj, GameObject mother_obj, Vector3 home_pos ){
        this._id = id;
        this._obj = obj;
        this._mother_obj = mother_obj;
        Debug.Log("生成の確認");
        setup( );
    }

    public void setup( ) {
        Debug.Log( "初期化処理" );
        _obj.AddComponent< Rigidbody >( );
        if( _mother_obj != null && _obj != null ){
             _mother_obj.GetComponent< Player>( ).addHenchmanList( _obj );
        }
   }

    public void update( ) {
        move( );
    }
    private void move( ) {
        Debug.Log( "移動の更新" );
        Vector3 this_pos = _obj.transform.position;
        Vector3 moter_pos = _mother_obj.transform.position;
        Vector3 movement = ( moter_pos - this_pos );
        Rigidbody rd = _obj.GetComponent< Rigidbody >( );
        rd.velocity = movement;
        rd.constraints = RigidbodyConstraints.FreezeRotationX |
                         RigidbodyConstraints.FreezeRotationZ;
    }
}

public class HenchmanManager : MonoBehaviour {
    [ SerializeField ] GameObject _mother_obj;
    [ SerializeField ] GameObject _child_prefab;
    public List< Henchman > _all_henchman_list;

    // Start is called before the first frame update
    void Start( ){
        _all_henchman_list = new List< Henchman >( );
        createChild( );
        createChild( );
        createChild( );
        createChild( );
    }

    // Update is called once per frame
    void Update( ) {
        foreach( Henchman henchman_data in _all_henchman_list ){
            henchman_data.update( );
        }
    }

    private void createChild( ) {
        GameObject child_obj = ( GameObject )Instantiate( _child_prefab );
        if( _mother_obj == null ) {
            return;
        }
        //motherが止まっている時のポジションを指定
        Vector3 new_home_pos = Vector3.zero;
        Vector3 base_pos = Vector3.zero;
        float angle = 0.0f;
        float sin = Mathf.Sin( angle );
        float cos = Mathf.Cos( angle );
        new_home_pos.x = cos * base_pos.x - sin * base_pos.y; 
        new_home_pos.x = sin * base_pos.x + cos * base_pos.y; 

        Henchman henchman = new Henchman( _all_henchman_list.Count + 1, child_obj, _mother_obj, new_home_pos );
        _all_henchman_list.Add( henchman );
    }
}
