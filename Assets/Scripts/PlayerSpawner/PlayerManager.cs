using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public List<GameObject> PlayerPrefabs;

    GameObject _spawnPoint;
    private void Awake()
    {
        _spawnPoint = GameObject.FindGameObjectWithTag("SpawnPoint");

    }
    private void Start()
    {
        StartCoroutine(SpawnPlayer());
    } 

    IEnumerator SpawnPlayer()
    {
        yield return new WaitForEndOfFrame();
        Instantiate(PlayerPrefabs[PlayerPrefs.GetInt("GenderSelected")]
            , _spawnPoint.transform.position, Quaternion.identity);
        yield return new WaitForEndOfFrame();
        Destroy(this.gameObject);
    }
}
