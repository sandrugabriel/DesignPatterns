using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Built_in_ASP_IoC_Container
{
    public class Card
    {
        protected string _name;
        protected int _attack;
        protected int _defense;

        public Card(string name, int attack, int defense)
        {
            _name = name;
            _attack = attack;
            _defense = defense;
        }

        public virtual string Name
        {
            get { return _name; }
        }

        public virtual int Attack
        {
            get { return _attack; }
        }

        public virtual int Defense
        {
            get { return _defense; }
        }


        //Lose Coupling
        public string Name1 {  get; set; }
        public int Attack1 {  get; set; }
        public int Defense1 {  get; set; }

        public Card()
        {

        }
    }
}
