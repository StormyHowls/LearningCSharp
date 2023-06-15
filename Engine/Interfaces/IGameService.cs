using Werewolf.Adventure;

namespace Werewolf.Engine.Interfaces
{
    public interface IGameService
    {
        bool StartGame(Game adventure = null);
    }
}