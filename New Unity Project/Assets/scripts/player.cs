﻿using UnityEngine;

public class player : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("碰到傳送們了");
    }
}
