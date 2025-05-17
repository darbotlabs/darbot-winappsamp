using System.Collections.Generic;

namespace Darbot9BitEngine
{
    public class GameHost
    {
        private readonly List<IGame> _games = new();
        private readonly GameContext _context = new();

        public void RegisterGame(IGame game)
        {
            _games.Add(game);
            game.Initialize(_context);
        }

        public void Update()
        {
            foreach (var g in _games)
            {
                g.Update(_context);
            }
        }

        public void Render()
        {
            foreach (var g in _games)
            {
                g.Render(_context);
            }
        }
    }
}
