using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    [SerializeField]GameObject _camera_obj;
    [SerializeField]GameObject _player_obj;
    Vector3 _offset;

    // Start is called before the first frame update
    void Start( ) {
        _camera_obj.transform.position = new Vector3( 0, 10, -10 );
        _offset = _camera_obj.transform.position - _player_obj.transform.position;
    }

    // Update is called once per frame
    void Update( ) {
        _camera_obj.transform.position = _player_obj.transform.position + _offset;
        _camera_obj.transform.LookAt(_player_obj.transform);
    }
}
