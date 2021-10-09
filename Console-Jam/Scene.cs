using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Jam
{
    class Scene
    {
        public Scene() { }
        public virtual void Start() { }
        public virtual void Update() { }
        public virtual void Draw() { }
        public virtual void End() { }
    }
}
