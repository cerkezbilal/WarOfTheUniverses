using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WarOfTheUniverses.Controllers;

namespace WarOfTheUniverses.Animations
{
    public class CharacterAnimation 
    {
        Animator _animator;

        public CharacterAnimation(PlayerController entity)
        {
            _animator = entity.GetComponentInChildren<Animator>();
        }

        public void MoveAnimations(float moveSpeed)
        {
            if (_animator.GetFloat("MoveSpeed") == moveSpeed) return;

            _animator.SetFloat("MoveSpeed", moveSpeed, 0.1f, Time.deltaTime);
        }
       
    }
}

