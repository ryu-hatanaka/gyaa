using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mother : MonoBehaviour
{
    protected List<GameObject> _henchman_list;
    protected float speed;

    public void addHenchmanList( GameObject obj ){
        _henchman_list.Add( obj );
    }
}
