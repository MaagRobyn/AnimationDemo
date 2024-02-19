using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Animator coinAnimation;
    [Min(0)]
    public float coinAnimationSpeed;
    public Animator boxAnimation;
    [Min(0)]
    public float boxAnimationSpeed;
    public Animator swordAnimation;
    [Min(0)]
    public float swordAnimationSpeed;

    // Update is called once per frame
    void Update()
    {
        if(coinAnimation.speed != coinAnimationSpeed && coinAnimationSpeed > 0)
        {
            coinAnimation.speed = coinAnimationSpeed;
        }
        if(boxAnimation.speed != boxAnimationSpeed && boxAnimationSpeed > 0) 
        { 
            boxAnimation.speed = boxAnimationSpeed;
        }
        if(swordAnimation.speed != swordAnimationSpeed && swordAnimationSpeed > 0) 
        { 
            swordAnimation.speed = swordAnimationSpeed; 
        }
        
    }
}
