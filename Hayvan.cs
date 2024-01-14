
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverLoadingExample
{
    internal class Hayvan
    {
        public virtual void Ses()
            //Kalııtm ile giden classtaki metota aşırı yükleme (override) yapar
        {
            Console.WriteLine("Sessiz bir hayvan.");
        }

    }

    class Dog:Hayvan
    {
        public override void Ses() 
            //Overriding (Kalıtım ile gelen metodu geçersiz kılar)
        {
            Console.WriteLine("Hav Hav");
        }
    }

    
}
