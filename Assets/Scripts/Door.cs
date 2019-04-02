﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour, IInteractable
{
    public int id;
    public bool open = false;
    
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (open /*&& transform.rotation.eulerAngles.y < 80*/)
        {
            //transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, 80, 0), 5);
            Destroy(this.gameObject);
            
        }
        /*else if (!open && transform.rotation.eulerAngles.y > 0)
        {
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, 0, 0), 5);
        }*/
    }
    public void Open()
    {
        if (id == -1 || Inventory.instance.HasKey(id))
        {
            open = !open;
        }

        if (id == 8)
        {
            if (GameManager.instance.input.text == GameManager.instance.desc)
            {
                open = !open;
            }
        }
    }
    public void Action()
    {
        Open();
    }
}
