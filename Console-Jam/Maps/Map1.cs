using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Jam
{
    class Map1 : Scene
    {
        private char _playerToken;
        private char _enemyToken;
        private char[,] _map;

        public override void Start()
        {
            Engine engine = new Engine();

            _playerToken = 'p';
            _map = new char[5, 10] {
                { '.', '.', '.', '.', '.' ,'.', '.', '.', '.', '.' },
                { '.', '.', '.', '.', '.' ,'.', '.', '.', '.', '.' },
                { '.', '.', '.', '.', '.' ,'.', '.', '.', '.', '.' },
                { '.', '.', '.', '.', '.' ,'.', '.', '.', '.', '.' },
                { '.', '.', '.', '.', '.' ,'.', '.', '.', '.', '.' },
            };
        }

        public override void Update()
        {
           
        }

        public override void Draw()
        {
            
        }

        public virtual void End() { }

    }
}
