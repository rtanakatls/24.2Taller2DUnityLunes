using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private int bullets;

    private Camera cam;
    
    private void Awake()
    {
        cam = GameObject.Find("Main Camera").GetComponent<Camera>();
        
    }

    private void Start()
    {
        BulletUIController.Instance.UpdateText(bullets);
    }

    private void Update()
    {
        Shoot();
    }

    private void Shoot()
    {
        if (Input.GetMouseButtonDown(0) && bullets > 0)
        {
            Vector2 mousePosition = cam.ScreenToWorldPoint(Input.mousePosition);
            Vector2 playerPosition = transform.position;

            Vector2 direction = mousePosition - playerPosition;
            GameObject bullet = Instantiate(bulletPrefab);
            bullet.transform.position = transform.position;
            bullet.GetComponent<BulletMovement>().SetDirection(direction.normalized);
            bullets--;
            BulletUIController.Instance.UpdateText(bullets);
        }
    }
}
