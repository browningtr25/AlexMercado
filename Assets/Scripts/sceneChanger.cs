using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class sceneChanger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Debug.Log("space key was pressed");
            SceneManager.LoadScene(0);
        }
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Debug.Log("space key was pressed");
            SceneManager.LoadScene(2);
        }
        if(Input.GetKeyDown(KeyCode.Mouse1)){
            SceneManager.LoadScene(1);
        }
        
    }
}