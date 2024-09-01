using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjSpawn : MonoBehaviour
{
    [SerializeField] private ObjFactory obj;
    // Start is called before the first frame update
    void Start()
    {
        IObj cube = obj.CreateObj(ObjFactory.ObjType.Cube, new Vector3(0,1,0));
        cube.Log();
    }
}
