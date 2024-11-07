using UnityEngine;

public class MiiPrimerScript : MonoBehaviour
{
    // la bariable public se usa par que las bariables se agan publicas y asi todos puedan mofificarlo 
     public int numero = 6;//numero entero
    float decimales = 3.14f ;// numeros decimales
    bool finJuego = false ;// booleanos
    string texto = "Esto es un texto";// cadena de texto
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        print("hola");
    }

    // Update is called once per frame
    void Update()
    {
        print("Que tal?");
    }
}
