using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameAsset : MonoBehaviour
{
    public static GameAsset instance;

    private void Awake() {
        instance = this;    
    }
    public Transform pfDavidBall;
    public Transform pfImpactPunch;
}
