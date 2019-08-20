using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onStart : MonoBehaviour
{
    // Start is called before the first frame update

    float movementSpeed = 15;
    float rotateSpeed = 50;
    public GameObject cube;
    public GameObject tank;
    void Start()
    {
        print("Hello World");
    }

    // Update is called once per frame
    void Update()
    {
        if (!(Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D)))
        {
            if (Input.GetKeyUp("f"))
            {
                print("Respect");
            }
        } else if(Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0f, rotateSpeed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f);
        }
        else if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
             transform.Translate(movementSpeed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, movementSpeed * Input.GetAxis("Vertical") * Time.deltaTime);
        }
        
        
    }

    public void onClickButtonText()
    {
        print("Hello World");
    }

    public void onClickButtonSpawnCube()
    {
        Instantiate(cube, new Vector3(190, 15, 85), Quaternion.identity);
    }
}
