using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.InheritanceOdev
{
   public abstract class Hayvanlar
    {
       public string _name;
       public string _tur;
       public   int _yas;
        public Hayvanlar() { }
        public Hayvanlar(string name,string tur,int yas)
        {
            _name = name;
            _tur = tur;
            _yas = yas;
        }


        public override string ToString()
        {
            return $"Hayvanin turu {_tur},hayvanin ismi {_name},hayvanin yasi {_yas}";
        }

        public abstract void sesCikar();
        
    }
    public class Kedi:Hayvanlar
    {
        public override void sesCikar()
        {
            Console.WriteLine("Kediler miyavv der");
        } 
    }
    public class Kopek : Hayvanlar     
    {
        public override void sesCikar()
        {
            Console.WriteLine("Kopekler havlar");
        }

    }
public class Kus : Hayvanlar
    {
        public override void sesCikar()
        {
            Console.WriteLine("Kuslar oter");
        }
    }

   


}
