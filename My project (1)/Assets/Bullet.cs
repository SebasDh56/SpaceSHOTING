using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed = 10f;
    public float lifeTime = 3f;  // Tiempo en segundos antes de que se destruya

    void Start()
    {
        // Autodestrucción del proyectil después de 'lifeTime' segundos
        Destroy(gameObject, lifeTime);
    }

    void Update()
    {
        // Mover la bala hacia adelante según la dirección en que esté mirando
        transform.Translate(transform.up * bulletSpeed * Time.deltaTime, Space.World);
    }
}
