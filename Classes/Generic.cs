using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Generics.Classes
{

    // Ved å legge til <T> i klasseerklæringen, indikerer man at klassen kan initieres med en valgfri type.
    public class ExampleGenerics<T>
    {
        // Det er hittil uavklart hvilken type  Value skal bestå av: den er generisk, ExampleGenerics kan initiaseres med hvilken som helst type.
        public T Value { get; set; }
        
    }
}