using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.Model
{
    public class Person
    {
        // Pola naszego modelu
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
