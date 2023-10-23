﻿using Built_in_ASP_IoC_Container;
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
            using(_http = new HttpClient())
            {
                var cardsJson = await _http.GetStringAsync("https://localhost:7155/api/cards");
                _player.Cards =  JsonConvert.DeserializeObject<IEnumerable<Card>>(cardsJson).ToArray();
            }
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

        

    }
}
