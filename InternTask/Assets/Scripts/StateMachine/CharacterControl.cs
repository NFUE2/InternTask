using System.ComponentModel;
using UnityEngine;

public class CharacterControl : MonoBehaviour
{
    [field :SerializeField] public Animator animator { get; private set; }
}