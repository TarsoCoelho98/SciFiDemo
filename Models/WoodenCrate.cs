using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodenCrate : MonoBehaviour
{
    public GameObject BrokenWoodenCratePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDestroy()
    {
        Instantiate(BrokenWoodenCratePrefab, this.gameObject.transform.position, Quaternion.identity);
    }
}
