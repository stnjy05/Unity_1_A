using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exenemy : MonoBehaviour
{
    private int damage = 20;
    public ExPlayer targetPlayer;

    public void AttackPlayer(ExPlayer player)
    {
        player.TakeDamage(damage);
        Debug.Log("�÷��̾� ����.");

    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            AttackPlayer(targetPlayer);
        }
    }
}
