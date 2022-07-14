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
        float default_range = 1.0f; //�q���Ɛe�s�̋���
        Vector3 mother_pos = _my_mother_go.transform.position;
        Vector3 henchman_pos = new Vector3( mother_pos.x + default_range, 0, mother_pos.z ); //�q���̏������W

        
        float radian = getColumn( ); //�q�����m�̊Ԋu

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
