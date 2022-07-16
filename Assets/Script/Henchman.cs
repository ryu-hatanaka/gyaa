using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Henchman : MonoBehaviour {
    private GameObject _my_mother_go; //�e�̃I�u�W�F�N�g
    private int _id; //Mother�ɓo�^����Ă���List��idx

    private Vector3 _home_position;
    public void setup( GameObject my_mother_go, int id ) {
        _my_mother_go = my_mother_go;
        _id = id;
        this.transform.position = my_mother_go.transform.GetChild( 0 ).gameObject.transform.position;
        settingHomePosition( );
    }
    public void update( ) {

    }

    public void moveCaseStop( ) {

    }

    private void moveCaseRun( ) {

    }

    /// <summary>
    /// ��~���̈ʒu��o�^
    /// </summary>
    private void settingHomePosition( ) {
        transform.position = getRotatePoint( 45, this.transform.position );
    }

    private Vector3 getRotatePoint( float radian, Vector3 go_pos ){
        float sin = MathF.Sin( radian );
        float cos = MathF.Cos( radian );
        Vector3 new_point;
        new_point.x = cos * go_pos.x - sin * go_pos.y;
        new_point.z = sin * go_pos.x + cos * go_pos.y;
        new_point.y = go_pos.y;
        return new_point;
    }

    private int getColumn( ) {
        int column_max_henchman_num = 4;
        int column = 1;
        while( true ) {
            if( _id <= column_max_henchman_num ) {
                return column;
            }
            column++;
            column_max_henchman_num *= 3;
        }

        Debug.LogError( "Henchman Column Error" );
        return -1;
    }
}
