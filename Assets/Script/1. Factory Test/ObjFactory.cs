using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IObj
{
    void Log();
}
public class ObjFactory : MonoBehaviour
{
    [SerializeField] private GameObject cube;
    [SerializeField] private GameObject sphere;
    [SerializeField] private GameObject cylinder;
    [SerializeField] private GameObject capsule;
    public enum ObjType { Cube, Capsule, Cylinder, Sphere }

    public IObj CreateObj(ObjType type, Vector3 position)
    {
        GameObject obj = null;
        switch (type)
        {
            case ObjType.Cube:
                obj = Instantiate(cube, position, Quaternion.identity);
                break;
            case ObjType.Capsule:
                obj = Instantiate(capsule, position, Quaternion.identity);
                break;
            case ObjType.Cylinder:
                obj = Instantiate(cylinder, position, Quaternion.identity);
                break;
            case ObjType.Sphere:
                obj = Instantiate(sphere, position, Quaternion.identity);
                break;
            default:
               throw new System.NotImplementedException();
        }
        return obj.GetComponent<IObj>();
    }
}
