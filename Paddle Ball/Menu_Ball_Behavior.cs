using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_Ball_Behavior : MonoBehaviour
{
    public Transform ts;
    private Quaternion rot;
    private readonly float a = 0;
    Vector3 pos = new Vector3(379, 189, 171);
    public GameObject gc;
    // Start is called before the first frame update
    void Start()
    {
        rot.x = 0;
        rot.y = a;
        rot.z = 0;
    }

    // Update is called once per frame
    void Update()
    {
        ts.rotation = rot;
        rot.y += 5;
        if (gc.GetComponent<ScreenSwitcher>().gameTrue && ts.position.z < 350)
        {
            DropBall();
        }
    }

    public void DropBall()
    {
        pos.z+=5;
        ts.position = pos;
        ts.localScale -= new Vector3(5f, 5f, 5f);
    }
}
