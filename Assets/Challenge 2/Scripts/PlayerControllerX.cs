using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float downTime = 0;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && downTime <= 0)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            downTime = 0.85f;
        }
        else if (downTime >= 0)
        {
            downTime = downTime - Time.deltaTime;
        }

    }
}
