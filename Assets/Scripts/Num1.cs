using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Num1 : MonoBehaviour
{
    public int num1;
    int resultado;

    // Start is called before the first frame update
    void Start()
    {
        num1 = 0;

        resultado = num1 + 2;
        Debug.Log(resultado);

        resultado = resultado * resultado;
        Debug.Log(resultado);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
