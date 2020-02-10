using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) == true)
        {
            Vector3 ray = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(ray, Vector2.zero);
            if (hit && hit.transform.gameObject.tag == "Bird")
            {
                GameObject hitObject = hit.transform.gameObject;
                hitObject.GetComponent<Bird>().enabled = false;
                hitObject.GetComponent<Rigidbody2D>().gravityScale = 10;
            }
        }
    }
}
