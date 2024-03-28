using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExparentClass : MonoBehaviour
{
    // Start is called before the first frame update
    public class ExparentClass : MonoBehaviour
    {
        protected int protectedValue;
    }

    // Update is called once per frame
    public class ExChildClass : ExparentClass
    {
        private void Start()
        {
            Debug.Log("Protected Value from Child Class : " + protectedValue);
        }
    }
