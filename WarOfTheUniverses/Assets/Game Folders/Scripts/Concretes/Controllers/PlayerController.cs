using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WarOfTheUniverses.Abstracts.Inputs;
using WarOfTheUniverses.Abstracts.Movements;
using WarOfTheUniverses.Animations;
using WarOfTheUniverses.Movements;

namespace WarOfTheUniverses.Controllers
{
    public class PlayerController : MonoBehaviour
    {
        [Header("Movement Informations")]
        [SerializeField] float _moveSpeed = 10f;

        IInputReader _input;
        IMover _mover;
        IRotator _xRotation;
        IRotator _yRotation;

        CharacterAnimation _animation;

        Vector3 _direction;

       

       [SerializeField] float _turnSpeed = 10f;

        [SerializeField] Transform _turnTransform;

        public Transform TurnTransform => _turnTransform;


        private void Awake()
        {
            _input = GetComponent<IInputReader>();
            _mover = new MoveWithCharacterController(this);
            _animation = new CharacterAnimation(this);
            _xRotation = new RotatorX(this);
            _yRotation = new RotatorY(this);
            
        }

        private void Update()
        {
            _direction = _input.Direction;

            

            _xRotation.RotationActions(_input.Rotation.x, _turnSpeed);
            _yRotation.RotationActions(_input.Rotation.y, _turnSpeed);
        }

        private void FixedUpdate()
        {
            _mover.MoveAction(_direction, _moveSpeed);
            
        }

        private void LateUpdate()
        {
            _animation.MoveAnimations(_direction.magnitude);
        }
    }//class
}

