using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Henchman : MonoBehaviour {
    private GameObject _my_mother_go; //親のオブジェクト
    private int _id; //Motherに登録されているListのidx

    private Vector3 _home_position;
    public void setup( GameObject my_mother_go, int id ) {
        _my_mother_go = my_mother_go;
        _id = id;

        settingHomePosition( );
    }
    public void update( ) {

    }

    public void moveCaseStop( ) {

    }

    private void moveCaseRun( ) {

    }

    /// <summary>
    /// 停止時の位置を登録
    /// </summary>
    private void settingHomePosition( ) {
        float default_range = 1.0f; //子分と親都の距離
        Vector3 mother_pos = _my_mother_go.transform.position;
        Vector3 henchman_pos = new Vector3( mother_pos.x + default_range, 0, mother_pos.z ); //子分の初期座標

        
        float radian = getColumn( ); //子分同士の間隔

        float new_sin = Mathf.Sin( radian );
        float new_cos = Mathf.Cos( radian );
        
        _home_position.x = new_cos * henchman_pos.x - new_sin * henchman_pos.z;
        _home_position.x = new_sin * henchman_pos.x + new_cos * henchman_pos.z;
    }
    
    private int getColumn( ){
        int column_max_henchman_num = 4;
        int column = 1;
        while( true ){
            if( _id <= column_max_henchman_num ) {
                return column;
            }
            column++;
            column_max_henchman_num *= 2;
        }

        Debug.LogError( "Henchman Column Error" );
        return -1;
    }
}
