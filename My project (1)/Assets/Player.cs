using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 5f; // Velocidad de movimiento del jugador
    public GameObject bulletPrefab; // Prefab del proyectil
    public Transform bulletSpawnPoint; // Punto desde donde se dispara el proyectil
    public float tiltAmount = 30f; // Aumento en la inclinación del movimiento lateral

    void Start()
    {
    }

    void Update()
    {
        Move();
        HandleShooting();
    }

    void Move()
    {
        // Captura el input horizontal (A/D o flechas izquierda/derecha)
        float moveX = Input.GetAxis("Horizontal");

        // Captura el input vertical (W/S o flechas arriba/abajo)
        float moveY = Input.GetAxis("Vertical");

        // Crea un vector de movimiento en el plano XY
        Vector3 movement = new Vector3(moveX, moveY, 0);

        // Mueve al jugador usando el vector de movimiento, la velocidad y el tiempo delta.
        transform.Translate(movement * moveSpeed * Time.deltaTime, Space.World);

        // Efecto de inclinación con mayor inclinación
        float tilt = moveX * tiltAmount;
        transform.rotation = Quaternion.Euler(0, 0, -tilt);
    }

    void HandleShooting()
    {
        // Dispara un proyectil cuando se presiona la barra espaciadora
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        // Instancia el proyectil en el punto de disparo
        Instantiate(bulletPrefab, bulletSpawnPoint.position, Quaternion.identity);
    }
}
