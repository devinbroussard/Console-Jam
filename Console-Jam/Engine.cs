using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Jam
{
    public enum BoostType
    {
        ATTACK,
        DEFENSE,
        NONE
    }

    public enum ItemID
    {
        BUN_SHIELD,
        CARROT_LANCE,
        COUNT
    }

    public struct Item
    {
        public string Name;
        public float StatBoost;
        public int Durability;
        public BoostType ItemType;
        public ItemID ItemID;
    }

    class Engine
    {
        private static bool _applicationShouldClose = false;
        private static int _currentSceneIndex;
        private Scene[] _scenes = new Scene[0];
        private Actor _actor;
        private Player _player;
        private string _playerName;
        private Item[] _itemList;

        /// <summary>
        /// Called to begin the application
        /// </summary>
        public void Run()
        {
            //Call start for the entire application
            Start();

            //Loops until the application is told to close
            while (!_applicationShouldClose)
            {
                Update();
                Draw();
            }

            //Called when the application closes
            End();
        }

        /// <summary>
        /// Called when the application starts
        /// </summary>
        private void Start()
        {
            InitializeItems();
            InitializeEnemies();
            _actor = new Actor('p', new Math_Library.Vector2 { X = 0, Y = 0 });
        }

        /// <summary>
        /// Creates all of the items in the game, as well as the lists they are apart of.
        /// </summary>
        private void InitializeItems()
        {
            Item bunShield = new Item { Name = "Bun Shield", ItemID = ItemID.BUN_SHIELD, ItemType = BoostType.DEFENSE, 
                Durability = 20, StatBoost = 7.5f };
            Item carrotLance = new Item { Name = "Carrot Lance", ItemID = ItemID.CARROT_LANCE, ItemType = BoostType.ATTACK,
                Durability = 35, StatBoost = 13f };

            _itemList = new Item[] { bunShield, carrotLance };
        }

        /// <summary>
        /// Initializes the enemies of the game, giving them their stats.
        /// </summary>
        private void InitializeEnemies()
        {
            Entity burgdude = new Entity(15, 12, 10, 'b', new Math_Library.Vector2 { X = 0, Y = 0 }, "Burgdude");
        }

        /// <summary>
        /// Called everytime the game loops
        /// </summary>
        private void Update()
        {
            _scenes[_currentSceneIndex].Update();
            _actor.Update();
        }

        /// <summary>
        /// Called every time the game loops to update visuals
        /// </summary>
        private void Draw() 
        {
            _scenes[_currentSceneIndex].Draw();
            _actor.Draw();
        }

        /// <summary>
        /// Called when the application exits
        /// </summary>
        private void End() 
        {
            _scenes[_currentSceneIndex].End();
        }

        /// <summary>
        /// Adds a scene to the engine's scene array
        /// </summary>
        /// <param name="scene">The scene that will be added to the scene array</param>
        /// <returns>The index where the new scene is located</returns>
        public int AddScene(Scene scene)
        {
            //Create a new temporary array
            Scene[] tempArray = new Scene[_scenes.Length + 1];

            //Copy all the values from the old array into the new array
            for (int i = 0; i < _scenes.Length; i++)
                tempArray[i] = _scenes[i];

            //Set the last index to be the new scene
            tempArray[_scenes.Length] = scene;

            //Set the old array to be the new array
            _scenes = tempArray;

            //Return the last index
            return _scenes.Length - 1;
        }
    }
}
