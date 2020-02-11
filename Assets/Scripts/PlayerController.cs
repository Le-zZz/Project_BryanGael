using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed = 5;
    
    private Vector3 targetPosition;
    private Vector3 startPosition;
   
    bool isMoving = false;

    public GameObject bulletPrefab;
    public Transform firePoint;
    private float bulletForce = 15f;
    
    private float fireRate;
    private float nextFire;

    private bool canShoot = false;

    private void Start()
    {
        fireRate = 0.5f;
        nextFire = Time.time;
    }


    void Update()
    {
        if(Input.GetMouseButton(0))
        {    
            SetTargetPosition();
            if (isMoving)
            {
                Move();
                if (canShoot)
                {
                    Shoot();
                }
            }
        }
    }

    void SetTargetPosition()
    {
        targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        targetPosition.z = transform.position.z;

        isMoving = true;
    }

    void Move()
    {
        transform.rotation = Quaternion.LookRotation(Vector3.forward, targetPosition);
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

        if (transform.position == targetPosition)
        {
            isMoving = false;
        }
    }

    void Shoot()
    {
        if (Time.time > nextFire)
        {

            GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
            nextFire = Time.time + fireRate;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer ("zombie"))
        {
            canShoot = true;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer ("zombie"))
        {
            canShoot = false;
        }
    }
}
