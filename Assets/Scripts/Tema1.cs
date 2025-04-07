using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tema1 : MonoBehaviour
{
    //1. Declaración de variables

    public float montoAConvertir;
    public string codigoMoneda;

    float montoConvertido;
    float montoMinimoAConvertir = 1000;

    float cotizacionMonedaElegida;
    float cotizacionDolar = 1297.21f;
    float cotizacionEuro = 1621.3f;
    float cotizacionReal = 183.0f;

    // Start is called before the first frame update
    void Start()
    {
        //2. Ingreso y validación de datos

        if (montoAConvertir < montoMinimoAConvertir )
        {
            Debug.Log("El monto mínimo es $1000");
            return;

        }
        if(codigoMoneda == "E")
        {
            cotizacionMonedaElegida = cotizacionEuro;
        }
        else if (codigoMoneda == "D")
        {
            cotizacionMonedaElegida = cotizacionDolar;
        }
        else if (codigoMoneda == "R")
        {
            cotizacionMonedaElegida = cotizacionReal;
        }
        else
        {
            Debug.Log("Opción de moneda extranjera no válida");
            return;
        }
        

        //3. Procesamiento de datos

        montoConvertido = montoAConvertir / cotizacionMonedaElegida;

        //4. Salida de datos
        Debug.Log("La conversión de ese monto de pesos equivale a " + montoConvertido);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
