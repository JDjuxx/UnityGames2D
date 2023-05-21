using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public GameObject bulletPrefab;
    public GameObject shooter;
    private Transform _firePoint;

    void Awake()
    {
        _firePoint = transform.Find("FirePoint");
    }
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Shoot", 1f);
        Invoke("Shoot", 5f);
        Invoke("Shoot", 10f);
        //Instantiate(bulletPrefab, _firePoint.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Shoot()
    {
        if(bulletPrefab != null && _firePoint != null && shooter != null)
        {
            GameObject myBullet = Instantiate(bulletPrefab, _firePoint.position, Quaternion.identity);
            Bullet bulletComponent = myBullet.GetComponent<Bullet>();

            if(shooter.transform.localScale.x < 0f)
            {
                bulletComponent.direction = Vector2.left;
            }
            else
            {
                bulletComponent.direction = Vector2.right;
            }
        }
    }
}
