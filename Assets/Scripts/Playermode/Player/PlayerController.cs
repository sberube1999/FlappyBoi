using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public class PlayerController : MonoBehaviour
    {
        private TranslateMover translateMover;

        void Awake()
        {
            translateMover = GetComponent<TranslateMover>();
        }
        void Start()
        {
            var position = transform.position;
            Debug.Log("Ma position initiale est : " + position);
        }

        void Update()
        {
            if (Input.GetKey(KeyCode.W))
                translateMover.Move(Vector3.up);
            if (Input.GetKey(KeyCode.A))
                translateMover.Move(Vector3.left);
            if (Input.GetKey(KeyCode.S))
                translateMover.Move(Vector3.down);
            if (Input.GetKey(KeyCode.D))
                translateMover.Move(Vector3.right);
        }
    }
}