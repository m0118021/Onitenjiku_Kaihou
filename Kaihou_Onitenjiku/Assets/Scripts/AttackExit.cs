﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackExit : MonoBehaviour
{
    public int randomCountMax;
    public GameObject Attack;
    private bool bossVs;
    public GameObject vsStart;
    public bool trigger;
    public GameObject Boss;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bossVs = vsStart.GetComponent<BossStartTrigger>().bossStart;
        trigger = Boss.GetComponent<MoveBoss>().fire;
       

        if (bossVs == true)
        {
            if (trigger == true)
            {
                Instantiate(Attack, this.gameObject.transform.position, Quaternion.identity);
            }
        }
    }
}
