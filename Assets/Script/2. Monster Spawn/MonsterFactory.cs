using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IMonsterMove
{
    public void Move();
}
public class MonsterFactory : MonoBehaviour
{
    [SerializeField] private GameObject slime;
    [SerializeField] private GameObject mushroom;
    [SerializeField] private GameObject cactus;
    [SerializeField] private GameObject turtleShell;

    [SerializeField] private Transform[] pos;

    public enum MonsterType { Slime, Mushroom, Cactus, TurtleShell }

    public IMonsterMove CreateMonster(MonsterType type)
    {
        GameObject monster = null;
        switch (type)
        {
            case MonsterType.Slime:
                monster = Instantiate(slime, pos[Random.Range(0, pos.Length)]);
                break;
            case MonsterType.Mushroom:
                monster = Instantiate(mushroom, pos[Random.Range(0, pos.Length)]);
                break;
            case MonsterType.Cactus:
                monster = Instantiate(cactus, pos[Random.Range(0, pos.Length)]);
                break;
            case MonsterType.TurtleShell:
                monster = Instantiate(turtleShell, pos[Random.Range(0, pos.Length)]);
                break;
            default:
                break;
        }
        return monster.GetComponent<IMonsterMove>();
    }
}