using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private int value; 

    public ExConstructor(int_value)
    {
        value = _value;
        Debug.Log("객체가 생성 되었습니다. 초기값 : " + value);
    }


    void Start()
    {
        ExConstructor ex = new ExConstructor(10);
    }

    private void update()
    {
        if(input.GetKeyDown(KeyCode.Space))
        {
            Destroy(this.gameObject);
        }
    }

    void OnDestory()
    {
        Debug.Log("객체가 파괴되었습니다");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
