using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WarOfTheUniverses.Abstracts.Movements;
using WarOfTheUniverses.Controllers;

namespace WarOfTheUniverses.Movements
{
    public class RotatorY : IRotator
    {
        Transform _transform;
        float _tilt;

        public RotatorY(PlayerController playerController)
        {
            //Bizim Player içindeki Cameras içindeki LookCameraPoint e ulaşmamız lazım
            _transform = playerController.TurnTransform;
            
        }


        public void RotationActions(float direction, float speed)
        {
            //Kamera oynayacak

            //gelen yöne göre olacak yani yukarı dersek değer + gelecek _tilt + olacak aşağıya bakarsan - olacak direction _tilt - olacak
           direction *= speed * Time.deltaTime;
            //dönme 30 derece ile -30 derece arasında olsun.
            _tilt = Mathf.Clamp(_tilt - direction, -30f, 30f);
            //x rotation da döncek
            _transform.localRotation = Quaternion.Euler(_tilt, 0f, 0f);

        }
    }

}
