using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjSpawn : MonoBehaviour
{
    [SerializeField] private ObjFactory obj;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CreateObj());
    }
    IEnumerator CreateObj()
    {
        yield return new WaitForSeconds(3f);

        IObj cube = obj.CreateObj(ObjFactory.ObjType.Cube, new Vector3(0, 1, 0));
        IObj capsule = obj.CreateObj(ObjFactory.ObjType.Capsule, new Vector3(2, 1, 0));
        IObj cylinder = obj.CreateObj(ObjFactory.ObjType.Cylinder, new Vector3(4, 1, 0));
        IObj sphere = obj.CreateObj(ObjFactory.ObjType.Sphere, new Vector3(6, 1, 0));

        cube.Log();
        capsule.Log();
        cylinder.Log();
        sphere.Log();
    }
}