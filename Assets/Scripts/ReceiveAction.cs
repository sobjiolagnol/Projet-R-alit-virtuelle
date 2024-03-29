using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReceiveAction : MonoBehaviour
{
    //Maximum de points de vie
    public int maxHitPoint = 5;

    //Points de vie actuels
    public int hitPoint = 0;

   /* public Animator anim;

    public GameObject ennemy;
    
    ParticleSystem fog;*/

    private void Start()
    {
        //Au début : Points de vie actuels = Maximum de points de vie
        hitPoint = maxHitPoint;
       /* fog = GetComponentInChildren<ParticleSystem>();
        fog.Pause(); */
    }


    //Permet de recevoir des dommages
    public void GetDamage(int damage)
    {
        //Applique les dommages aux points de vies actuels
        hitPoint -= damage;
      /*  if(hitPoint < 4)
        {
            fog.Play();
        }
        if(hitPoint < 3)
        {
            fog.startColor = new Color(0, 0, 0, 0.20f);
        }*/
        //Si les point de vie sont inférieurs à 1 = Supprime l'objet
        if (hitPoint < 1)
        {
            /*anim.Play("10-death_fall_backward", 0, 0.25f);
            hitPoint = 5;*/
            Destroy(gameObject);
        }
    }
}
