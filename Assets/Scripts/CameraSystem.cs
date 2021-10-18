using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSystem : MonoBehaviour
{
    private GameObject shark;
    //Lock camera position
    public float xMin;
    public float xMax;
    public float yMin;
    public float yMax;

    // Start is called before the first frame update
    void Start()
    {
        shark = GameObject.FindGameObjectWithTag("Player");
    }

    void LateUpdate()
    {
        float x = Mathf.Clamp(shark.transform.position.x, xMin, xMax);
        float y = Mathf.Clamp(shark.transform.position.y, yMin, yMax);
        gameObject.transform.position = new Vector3(x, y, gameObject.transform.position.z);
    }
}
