using UnityEngine;
using System.Collections;

public class gEnemy : MonoBehaviour
{

    [System.Serializable]
    public class EnemyStats
    {
        public int damage;
        // TODO: change to FLOAT as avaible;
        public float starthpmultiplier = 1f;
        public float maxHealth = 100;
       /* {
            get { return maxHealth; }
            set { maxHealth = value; }
        }*/
        private float _curHealth;
        public float curHealth
        {
            get { return _curHealth; }
            set { _curHealth = Mathf.Clamp(value, 0, maxHealth); }
        }

        public EnemyStats()
        {
            damage = 10;
          maxHealth = 100f;
          curHealth = maxHealth*starthpmultiplier;
        }
    }
    public EnemyStats stats = new EnemyStats();
 
    public static void KillEnemy(gEnemy other)
    {
        Destroy(other.gameObject);
    }
    public void DamageEnemy(int damage)
    {
        Debug.Log("PlayerHitsEnemy");
        stats.curHealth -= damage;
        if (stats.curHealth <= 0)
        {
            KillEnemy(this);
        }
    }

    private void OnCollisionEnter2D (Collision2D _collinfo)
    {
        Warrior _player = _collinfo.collider.GetComponent<Warrior>();
        Debug.Log("PlayerHitsEnemy");
        if (_player != null)
        {
            Debug.Log("PlayerHitsEnemy");
            _player.SetHealth(_player.GetHealth()- stats.damage);
        }
    }
}

