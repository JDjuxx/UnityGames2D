using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C3L3 : MonoBehaviour
{
    public int myInteger = 5;
    public float myFloat = 3.5f;
    public bool myBoolean = true;
    public string myString = "Hello!";
    public int[] myArrayOfInts;

    private int _myPrivateInt = 10;
    // float _myPrivateFloat = -5.9f;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("let's sum 10 to myIntege. Right now its value is "+myInteger);
        myInteger = myInteger + this._myPrivateInt;
        Debug.Log("Now it's value is: "+myInteger);

        if(isEven(myInteger)){
            MyDebug("It's an even number!!!");
        }else{
            MyDebug("It's an odd number!!!");
        }

        SpriteRenderer mySpriteRenderer = GetComponent<SpriteRenderer>();
        
        if(mySpriteRenderer != null){
            MyDebug("I can use mySpriteRenderer");
        }else{
            MyDebug("The game will crash if you try to use the component");
        }

        GameObject anObjectWithSpriteRenderer = FindObjectOfType<SpriteRenderer>().gameObject;

        GameObject anObjectWithTag = GameObject.FindWithTag("Player");
        GameObject anObjectWithName = GameObject.Find("Wathever come you now");

        if(mySpriteRenderer != null)
        {
            mySpriteRenderer.enabled = false;
        }

        if(anObjectWithName != null)
        {
            anObjectWithName.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    bool isEven(int num){
        if(num % 2 == 0){
            return true;
        }else{
            return false;
        }
    }

    void MyDebug(string message){
        Debug.Log(message);
    }
}
