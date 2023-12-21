using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newspawner : MonoBehaviour
{
    public GameObject platform;
    public float spawnDelay = 1f;
    public bool randomY = false;
    public float zPosition = 0f;
    public float spawnPositionX = 42.6f;
    public GameObject animatedObjectPrefab;
    public float spawnRate = 1f;
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
        int spawnPointY = Random.Range((int)sp.bounds.min.y, (int)sp.bounds.max.y);
        //int spawnPointX = 42.6f;
        spawnedObject = Instantiate(animatedObjectPrefab, transform.position + (new Vector3(0, spawnPointY, 0)), Quaternion.identity);
        if (AnimationName != "")
        {
            Animator animator = spawnedObject.GetComponent<Animator>();
            animator.Play(AnimationName);
        }
        Invoke("Spawn", spawnDelay);
    }
}
