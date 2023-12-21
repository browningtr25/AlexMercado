using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxMove : MonoBehaviour
{
    public GameObject[] layers;

    public float[] speeds;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        foreach (GameObject layer in layers)
        {
            float? lastX = null;
            foreach (Transform child in layer.transform)
            {
                GameObject obj = child.gameObject;
                //starting img
                if (lastX != null)
                {
                    var position = child.position;
                    position = new Vector3(lastX.Value, position.y, position.z);
                    child.position = position;
                }
                lastX = child.position.x + obj.GetComponent<SpriteRenderer>().bounds.size.x;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        int i = 0;
        foreach (GameObject layer in layers)
        {
            Transform first = null;
            Transform last = layer.transform.GetChild(0);
            foreach (Transform child in layer.transform)
            {
                var position = child.position;
                position -= new Vector3(speeds[i] * Time.deltaTime, 0, 0);
                child.position = position;
                float realX = child.gameObject.GetComponent<SpriteRenderer>().bounds.max.x;
                if (realX <= OrthographicBounds().min.x)
                {
                    first = child;
                }
                if (child.position.x > last.position.x)
                {
                    last = child;
                }
            }
            if (first)
            {
                var position = first!.position;
                position = new Vector3(
                    last.position.x + last
                        .gameObject.GetComponent<SpriteRenderer>().bounds.size.x, position.y, position.z);
                first.position = position;
            }
            i++;
        }
    }

    public Bounds OrthographicBounds()
    {
        float screenAspect = (float)Screen.width / (float)Screen.height;
        float cameraHeight = GetComponent<Camera>().orthographicSize * 2;
        Bounds bounds = new Bounds(
            this.transform.position,
            new Vector3(cameraHeight * screenAspect, cameraHeight, 0));
        return bounds;
    }

}