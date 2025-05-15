using _GameFolders.Scripts.Abstracts.Input;
using _GameFolders.Scripts.Abstracts.Interfaces;
using UnityEngine;

namespace _GameFolders.Scripts.Concretes.Controller
{
    public class PlayerController : MonoBehaviour, IPlayerController
    {
        public IInputReader InputReader { get; set; }
    }
}
