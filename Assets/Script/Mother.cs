using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mother : MonoBehaviour
{
    public List<GameObject> _henchman_list;
    // Start is called before the first frame update
    public void addHenchmanList( GameObject obj ){
        _henchman_list.Add( obj );
    }
}
