using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed = 10f;
    public float lifeTime = 3f;  // Tiempo en segundos antes de que se destruya

    void Start()
    {
        // Autodestrucci�n del proyectil despu�s de 'lifeTime' segundos
        Destroy(gameObject, lifeTime);
    }

    void Update()
    {
        // Mover la bala hacia adelante seg�n la direcci�n en que est� mirando
        transform.Translate(transform.up * bulletSpeed * Time.deltaTime, Space.World);
    }
}
