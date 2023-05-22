using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnEnemy : MonoBehaviour
{
    public GameObject enemy; //enemy object
    public int xPos;
    public int zPos;
    public float yPos = 1.5f;
    public int enemyCount;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawn());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator Spawn()
    {
        while (enemyCount <= 1)
        {
            xPos = -10;
            zPos = 10;
            Instantiate(enemy, new Vector3(xPos, 5, zPos), Quaternion.identity);
            yield return new WaitForSeconds(1f);
            enemyCount++;
        }
    }
}
