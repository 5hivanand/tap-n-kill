using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public float flySpeed;
    public Vector3 currPos;

    // Start is called before the first frame update
    void Start()
    {
        currPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        currPos.x = currPos.x + Time.deltaTime * flySpeed;
        transform.position = currPos;
    }
}
