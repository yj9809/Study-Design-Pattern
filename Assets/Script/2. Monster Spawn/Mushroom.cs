using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mushroom : MonoBehaviour, IMonsterMove
{
    private Player p;
    private float speed = 4f;
    private float rotationSpeed = 10f;

    public void Move()
    {
        Vector3 direction = (p.transform.position - transform.position).normalized;
        Vector3 moveAmount = direction * speed * Time.deltaTime;
        Quaternion pRotation = Quaternion.LookRotation(direction);

        transform.position += moveAmount;
        transform.rotation = Quaternion.Slerp(transform.rotation, pRotation, rotationSpeed * Time.deltaTime);
    }

    // Start is called before the first frame update
    void Start()
    {
        p = FindObjectOfType<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
}
