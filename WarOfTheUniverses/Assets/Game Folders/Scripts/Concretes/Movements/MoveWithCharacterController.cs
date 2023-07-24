using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WarOfTheUniverses.Abstracts.Movements;
using WarOfTheUniverses.Controllers;

namespace WarOfTheUniverses.Movements
{
    public class MoveWithCharacterController : IMover
    {
        CharacterController _characterController;

        

        public MoveWithCharacterController(PlayerController playerController)
        {
            _characterController = playerController.GetComponent<CharacterController>();
           
        }

       


        public void MoveAction(Vector3 direction, float moveSpeed)
        {

            if (direction.magnitude == 0f) return;//Yukarıdaki ile aynı şey

            //Karakterimin gerçek dünya pozisyonuna gelen direction u ver
            Vector3 worldPosition = _characterController.transform.TransformDirection(direction);

            
            Vector3 movement = worldPosition * Time.deltaTime * moveSpeed;

            _characterController.Move(movement);
        }


    }//class
}

