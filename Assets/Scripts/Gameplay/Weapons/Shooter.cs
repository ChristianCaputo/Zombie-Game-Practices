using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gameplay.Weapons
{  
    public class Shooter : MonoBehaviour
    {
        private LayerMask enemyLayer;
        [SerializeField] private GameObject blood;
        //public delegate void HitEnemy();
        //public static event HitEnemy hitFx;

        public void Start()
        {
            enemyLayer = LayerMask.GetMask("Enemy");
        }

        public void Update()
        {            
            RaycastHit hit;
            bool hitEnemy = Physics.Raycast (transform.position, transform.forward, out hit, enemyLayer);

            if(hitEnemy)
            {
                //print("Enemy hit!"+ hit.collider.gameObject.name);
                Life life = hit.collider.gameObject.GetComponent<EnemyLife>();
                life.Damage(2);
                //hitFx();
                Instantiate(blood, hit.point, transform.rotation);
            }
        }

        /*private void OnDrawGizmos()
        {
            Gizmos.color = Color.red;
            Gizmos.DrawLine(transform.position, new Vector3(0, 0, 20));
        }*/
    }
}

//LifeTest life = hit.collider.gameObject.GetComponent<LifeTest>();




