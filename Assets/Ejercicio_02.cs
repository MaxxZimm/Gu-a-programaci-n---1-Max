    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_02 : MonoBehaviour
{
    //2. Realizá un programa que, siendo num1 y num2 variables enteras con valores 4 y 5,  respectivamente, realice la operación correspondiente y muestre el resultado en pantalla: 
    //a.Suma
    //b.Producto

    int num1 = 4;
    int num2 = 5;
    
    void Start()
    {
        int res1 = num1 + num2;
        int res2 = num1 * num2;
        Debug.Log("La suma entre 4 y 5 es igual a " + res1);
        Debug.Log("La multiplicación entre 4 y 5 es igual a " + res2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
