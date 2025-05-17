namespace Darbot9BitEngine
{
    public interface IGame
    {
        string Name { get; }
        void Initialize(GameContext context);
        void Update(GameContext context);
        void Render(GameContext context);
    }
}
