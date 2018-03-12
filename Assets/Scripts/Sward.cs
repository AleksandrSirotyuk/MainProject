using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sward : MonoBehaviour {
    GameObject EnemyClass;
    gEnemy genm;
    private int curHP = 0;
    // Use this for initialization
    void Start () {
        EnemyClass = GameObject.Find("enemy");
        genm = EnemyClass.GetComponent<gEnemy>();
    }

    private void OnCollisionEnter2D(Collision2D _collinfo)
    {
        gEnemy _player = _collinfo.collider.GetComponent<gEnemy>();
        Debug.Log("PlayerHitsEnemy");
        if (_player != null)
        {
            Debug.Log("PlayerHitsEnemy");
            _player.DamageEnemy(80);
        }
    }
}
