using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    int number = 1;
    float floatNumber = 2.34f;
    string text = "to jest tekst";
    bool logical = true;
    int[] intArray;
    int[] intArray2 = new int[] {1,2,3,4};
    int[] intArray3 = (1, 2, 3, 4);

    List<int> list = new List<int>();

   private int MyMethod()
    {
        return number;
    }
    
    private void Awake()
    {
        Debug.Log("Awake");
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start" + MyMethod());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

