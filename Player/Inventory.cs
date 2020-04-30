using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public bool isCoinCollected = false;
    public AudioClip CoinSound;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CollectCoin()
    {
        AudioSource.PlayClipAtPoint(CoinSound, transform.position);
        isCoinCollected = true;
    }
}
