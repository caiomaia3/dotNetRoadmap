using System;
using System.Collections.Generic;
using System.Text;

namespace Pensionato
{
    class Quartos
    {
        private int _room;
        public string Name { get; private set; }
        public string Email { get; private set; }

        public Quartos(string name, string email, int room)
        {
            Name = name;
            Email = email;
            _room = room;
        }

        public override string ToString()
        {
            return $"{_room}: {Name}, {Email}";
        }
    }
}
