using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpawn : MonoBehaviour
{
    [SerializeField] private MonsterFactory mF;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawn());
    }
    private IEnumerator Spawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(3f);

            IMonsterMove monster = mF.CreateMonster((MonsterFactory.MonsterType)Random.Range(0, 4));
        }
    }
}
