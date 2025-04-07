using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComidaAnimalitos : MonoBehaviour
{
    public string codigo;
    public int diasQueSeQueda;
    

    // Start is called before the first frame update
    void Start()
    {
        if (codigo == "G" && diasQueSeQueda > 3)
        {
            
        }
        else if (codigo == "PP" && diasQueSeQueda > 3)
        {

        }  
        else if (codigo == "PG" && diasQueSeQueda > 3)
        {

        }
        else
        {
            Debug.Log("El codigo y/o días de estadia no es/son valido/s");
            return;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
