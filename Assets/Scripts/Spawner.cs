using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject platform;
    public float spawnDelay = 1f;
    public bool randomY = false;
    public float zPosition = 0f;
    public float spawnPositionX = 42.6f;
    public GameObject animatedObjectPrefab;
    //public float spawnRate = 1f;
    public float spawnPositionXOffset;
    private float spawnTimer = 5f;
    private GameObject spawnedObject;
    public string AnimationName;
    public GameObject bg;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Spawn", spawnDelay);
    }

    void GameOver()
    {
        Time.timeScale = 0;
    }
    /// <summary>

    /// </summary>
    void Spawn()
    {
        SpriteRenderer sp = bg.GetComponent<SpriteRenderer>();
        float spawnPointY = Random.Range((sp.bounds.min.y + .2f), (sp.bounds.max.y - 0.1f));
        Debug.Log((sp.bounds.min.y + .20f));
        //int spawnPointX = 42.6f;
        spawnedObject = Instantiate(animatedObjectPrefab, new Vector3(transform.position.x, spawnPointY, transform.position.z), Quaternion.identity);
        if (AnimationName != "")
        {
            Animator animator = spawnedObject.GetComponent<Animator>();
            animator.Play(AnimationName);
        }
        Invoke("Spawn", spawnDelay);
    }
}