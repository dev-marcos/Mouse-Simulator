using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimentacao_Mouse : MonoBehaviour
{
    float unidadesTx, unidadesTy, unidadesTz;//unidades de translacao em x e em z
    float vT; //velocidade de translacao
    //Rigidbody rb;
    //public float forca = 10;
    // Start is called before the first frame update
    void Start()
    {
        vT = 5.0f;
        //rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //A ou seta direc para esq= -1 | D ou seta direc para dir = 1
        unidadesTx = Input.GetAxis("Horizontal") * vT * Time.deltaTime;
        //S ou seta direc para baixo= -1 | W ou seta direc para cima = 1
        unidadesTy = Input.GetAxis("Vertical") * vT * Time.deltaTime;
        // Scrool do mouse para movimentar

        if (Input.GetAxis("Mouse ScrollWheel") > 0f) // forward
        {
            unidadesTz=0.1f;
        }
        else if (Input.GetAxis("Mouse ScrollWheel") < 0f) // backwards
        {
            unidadesTz=-0.1f;
        }
        transform.Translate(unidadesTy, unidadesTx, unidadesTz);
        unidadesTz = 0f;
      /*  if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(transform.forward * forca);
        }*/
    }
}
