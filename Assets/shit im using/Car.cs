using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{

    public GameObject car;

    public float LeftX;
    public float RightX;

    public float MoveSpeed;

    private bool startmovingleft = false;
    private bool startmovingright = false;

    // Use this for initialization
    void Start()
    {
        Debug.Log("exists");
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.DrawRay(car.transform.position, car.transform.forward, Color.green,45);
        moveleft();
        moveright();
        if (Physics.Raycast(car.transform.localPosition, car.transform.forward, 20))
        {
            
            Debug.Log("should move now");
            if (car.transform.localPosition.x < 0 && car.transform.localPosition.x < RightX)
            {
              
                Debug.Log("should move right");
                startmovingright = true;
            }
           
            else if (car.transform.localPosition.x > 0 && car.transform.localPosition.x > LeftX)
            {
                startmovingleft = true;

                Debug.Log("should move left");

                
            }
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.LoadLevel("menu");
        }
    }

  void moveleft()
    {
        if (startmovingleft == true)
        {
            car.transform.Translate(Vector3.left * MoveSpeed * Time.deltaTime);
            if (car.transform.position.x <= LeftX)
            {
                startmovingleft = false;
            }
        }
    }

    void moveright()
    {
        if (startmovingright == true)
        {
            car.transform.Translate(Vector3.right * MoveSpeed * Time.deltaTime);
            if (car.transform.position.x >= RightX)
            {
                startmovingright = false;
            }
        }
    }

}
