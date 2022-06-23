using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimentacao_Camera : MonoBehaviour
{
    public float unidadesRx, unidadesRy; //unidades de rotacao em x e em y;
    float vR; //velocidade de rotacao
    public GameObject personagem;

    void Start()
    {
        vR = 100f;
        unidadesRx = 90f;
        Cursor.lockState = CursorLockMode.Locked;
    }


    void Update()
    {
        unidadesRx += Input.GetAxis("Mouse Y") * vR * Time.deltaTime * 2f;
        unidadesRx = Mathf.Clamp(unidadesRx, 0f, 180f);
        transform.localEulerAngles = new Vector3(180, -unidadesRx, -90);

        unidadesRy = Input.GetAxis("Mouse X") * vR * Time.deltaTime;
        personagem.transform.Rotate(0, 0, unidadesRy);
    }
}
