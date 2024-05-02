using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject CircleObject;
    public Transform genTransform;
    public float timecheck;
    public bool isGen;

    public void GenObject()
    {
        isGen = false;
        timecheck = 1.0f;
    }
    // Start is called before the first frame update
    void Start()
    {
        GenObject();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isGen==false)
        {
            timecheck -= Time.deltaTime;
            if(timecheck<=0.0f)
            {
                GameObject Temp = Instantiate(CircleObject);
                Temp.transform.position = genTransform.position;
                isGen = true;
            }
        }
    }
}
