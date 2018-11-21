using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Boss{

    int mp = 53;

    public void Magic(int use)   {
        if (mp >= use) {
            this.mp -= use;
            Debug.Log("魔法攻撃した。残りｍｐは" + mp);

        } else {
            Debug.Log("mpが足りないため魔法が使えません。");
        }
    }
}

public class Test : MonoBehaviour {
    // Use this for initialization
    void Start()
    {
        int[] array = { 10, 20, 30, 40, 50 };

        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }
        //int[] arrays = new int[5];

        // arrays[0] = 10;
        // arrays[1] = 20;
        //arrays[2] = 30;
        // arrays[3] = 40;
        // arrays[4] = 50;

        //for (int i = 4; i >= 0; i--)
        for(int i= array.Length -1; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }

        Boss lastboss = new Boss();

        for (int i = 0; i < 11; i++) {
            lastboss.Magic(5);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }



}  
    

