using System.Collections;
using UnityEngine;

public class WaveManager : MonoBehaviour
{
    
        public GameObject[] enemyPrefabs;
        public Transform[] spawnPoints;
    public int cantEnemy =1;
        public float timeBetweenHordes = 20f;

        private int currentHorde = 1;

        void Start()
        {
            StartCoroutine(SpawnHordes());
        }

        IEnumerator SpawnHordes()
        {
            while (currentHorde <= 10)
            {
                Debug.Log("Horda " + currentHorde + " comienza.");

                for (int i = 0; i < spawnPoints.Length; i++)
                {
                    for (int j = 0; j < cantEnemy; j++)
                    {
                        Instantiate(enemyPrefabs[Random.Range(0, enemyPrefabs.Length)], spawnPoints[i].position, Quaternion.identity);
                    }
                    
                }

                currentHorde++;
                cantEnemy++;
                yield return new WaitForSeconds(timeBetweenHordes);
            }
        }
 }

