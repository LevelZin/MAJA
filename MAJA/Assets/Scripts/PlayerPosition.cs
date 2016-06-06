using UnityEngine;
using System.Collections;

public class PlayerPosition : MonoBehaviour {

    [SerializeField]
    private GameObject Player;

    void awake()
    {
        DontDestroyOnLoad(Player);
    }

    void Start()
    {

    }

    void Update()
    {

    }

}
