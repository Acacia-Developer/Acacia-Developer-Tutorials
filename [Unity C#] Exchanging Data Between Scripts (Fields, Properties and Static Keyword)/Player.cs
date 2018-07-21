using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private int health;

    public int Health
    {
        get { return health; }
        set
        {
            if (value < 0 || value > 100)
                Debug.LogError("Health is less than 0 or larger than 100!");
            else
            {
                health = value;
                
                if (value == 0)
                {
                    isDead = true;
                    //function call to play death animation
                }
                    
            }
                  
                
        }
    }

    public bool isDead;
    public static float walkSpeed;
    public static float runSpeed;

    void Start()
    {
        Debug.Log(runSpeed);
    }

}
