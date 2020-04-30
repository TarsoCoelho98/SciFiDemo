using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerControls : MonoBehaviour
{
    private NavMeshAgent Agent;
    private Inventory Inventory;
    public GameObject Weapon;
    
    private byte Aceletarion = 10;
    public byte Gravity = 10;

    // Start is called before the first frame update
    void Start()
    {
        Agent = GetComponent<NavMeshAgent>();
        Inventory = GetComponent<Inventory>();
    }

    // Update is called once per frame
    void Update()
    {
        Controls();
    }

    public void Controls()
    {
        var direction = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        var velocity = Aceletarion * direction;

        velocity.y -= Gravity; // Gravity Force 
        velocity = transform.transform.TransformDirection(velocity); // Transform To World Space Reference

        Agent.Move(velocity * Time.deltaTime);        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Coin")
        {
            Inventory.CollectCoin();
            Destroy(other.gameObject);
        }
        else if (other.gameObject.name == "Sharkman")
        {
            if (Inventory.isCoinCollected)
            {
                Debug.Log("Parabéns.");
                Weapon.SetActive(true);
            }
            else
            {
                Debug.Log("Encontre a moeda.");
            }
        }
    }
}
