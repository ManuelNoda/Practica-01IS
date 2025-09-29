using UnityEngine;

public class posicion : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
     void Start()
    {
        // Cada objeto escribe en consola su tag y su posición
        Debug.Log("Objeto: " + gameObject.tag + " | Posición: " + transform.position);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
