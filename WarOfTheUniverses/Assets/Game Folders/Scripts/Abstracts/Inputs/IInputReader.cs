using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WarOfTheUniverses.Abstracts.Inputs
{
    public interface IInputReader
    {
        Vector3 Direction { get; }

        Vector2 Rotation { get; }
    }
}

