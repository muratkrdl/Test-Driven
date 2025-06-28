using _GameFolders.Scripts.Abstracts.Input;

namespace _GameFolders.Scripts.Abstracts.Interfaces
{
    public interface IPlayerController : IEntityController
    {
        IInputReader InputReader { get; set; }
    }
}