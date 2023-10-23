using Built_in_ASP_IoC_Container;
using Loose_Coupling.Event;
using Loose_Coupling.Observer;
using Loose_Coupling.Poxy;
using Loose_Coupling.Strategies;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;
using System.Threading.Tasks;

namespace Loose_Coupling.Facades
{
    public class GameBoardFacade
    {
        private PrimaryPlayer _player;
        private int _areaLevel;
        private HttpClient _client;
        private EnemyFactory _factory;
        private List<IEnemy> _enemies;
        private HttpClient _http;
        private CardsProxy cardsProxy;

        public GameBoardFacade()
        {
            cardsProxy = new CardsProxy();
        }

        public async Task PlayAsync( PrimaryPlayer player, int areaLevel)
        {
            _player = player;
            _areaLevel = areaLevel;
            ConfigurePlayerWeapon();
            await AddPlayerCards();
            InitializeEnemyFactory(areaLevel);
            LoadZombies(areaLevel);
            LoadWolf(areaLevel);
            LoadGiant(areaLevel);
            StartTurns();
        }

        private void LoadGiant(int areaLevel)
        {
            int count;
            if (areaLevel < 8)
            {
                count = 1;
            }
            else
            {
                count = 3;
            }
            for (int i = 0; i < count; i++)
            {
                _enemies.Add(_factory.SpawnGiant(areaLevel));
            }
        }

        private void ConfigurePlayerWeapon()
        {
            string input;
            int chioce;
            while (true)
            {
                Console.WriteLine("Pick a weapon: ");
                Console.WriteLine("1. Sword");
                Console.WriteLine("2. Fire Staff");
                Console.WriteLine("3. Ice Staff");
                input = Console.ReadLine(); 
                if(Int32.TryParse(input, out chioce))
                {
                    if(chioce == 1)
                    {
                        _player.Weapon = new Sword(15, 7);
                    }else if(chioce == 2)
                    {
                        _player.Weapon = new FireStaff(15,7);

                    }else if(chioce == 3)
                    {
                        _player.Weapon = new IceStaff(23, 3);
                    }
                }
            }
        }

        private async Task AddPlayerCards()
        {
           _player.Cards = (await cardsProxy.GetCards()).ToArray();
        }

        private void InitializeEnemyFactory(int areaLevel)
        {
            _factory = new EnemyFactory(areaLevel);
        }

        private void LoadZombies(int areaLevel)
        {
            int count;
            if (areaLevel < 3)
            {
                count = 10;
            }
            else if (areaLevel >= 3 && areaLevel < 10)
            {
                count = 20;
            }
            else
            {
                count = 30;
            }
            for (int i = 0; i < count; i++)
            {
                _enemies.Add(_factory.SpawnZombie(areaLevel));
            }
        }

        private void LoadWolf(int areaLevel)
        {
            int count;
            if (areaLevel < 5)
            {
                count = 3;
            }
            else
            {
                count = 10;
            }
            for (int i = 0; i < count; i++)
            {
                _enemies.Add(_factory.SpawnWereWolf(areaLevel));
            }

        }

        private void StartTurns()
        {
            IEnemy enemy = null;

            while(true)
            {
                if(enemy == null)
                {
                    if(_enemies.Count > 0) {
                    
                        enemy = _enemies[0];  
                        _enemies.RemoveAt(0);

                    }
                    else
                    {
                        Console.WriteLine("You won this level!");
                        break;
                    }
                }

                //  _player.Weapon.Use(enemy);
                //  enemy.Attack(_player);

               int damage =  enemy.Attack(_player);
                _player.Hit(damage);
                var regularObserver = new HealthChangedObserver(new RegularDamageIndicator());
                var criticalObserver = new HealthChangedObserver(new CriticalHealthIndicator());
                regularObserver.WatchPlayerHealth(_player);
                criticalObserver.WatchPlayerHealth(_player);
                Thread.Sleep(500);
            }
        }
        

    }
}
