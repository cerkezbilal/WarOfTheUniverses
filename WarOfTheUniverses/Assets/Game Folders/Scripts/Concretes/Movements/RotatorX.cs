using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WarOfTheUniverses.Abstracts.Movements;
using WarOfTheUniverses.Controllers;

namespace WarOfTheUniverses.Movements
{
    public class RotatorX : IRotator
    {
        PlayerController _playerController;


        public RotatorX(PlayerController playerController)
        {
            _playerController = playerController;
        }

        public void RotationActions(float direction, float speed)
        {
            //Karakter oynayacak (up olma nedeni (y de döndürmesinden kaynaklanıyor)
            _playerController.transform.Rotate(Vector3.up * direction * Time.deltaTime * speed);
        }
    }
}

