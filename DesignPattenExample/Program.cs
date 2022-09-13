using DesignPattenExample.FactoryMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattenExample
{
    class Program
    {
        static void Main(string[] args)
        {
            RunFactoryMethodPatten();
        }

        /// <summary>
        /// 싱글톤 패턴 예제 
        /// </summary>
        static void RunSingletonPatten()
        {
            SingletonExample singletonA = SingletonExample.Instance();
            singletonA.Name = "A로 설정";
            Console.WriteLine($"singletonA.Name = {singletonA.Name}");


            SingletonExample singletonB = SingletonExample.Instance();
            Console.WriteLine($"singletonB.Name = {singletonB.Name}");


            SingletonExample singletonC = SingletonExample.Instance();
            Console.WriteLine($"singletonC.Name = {singletonC.Name}");
        }

        static void RunFactoryMethodPatten()
        {
            UnitCreater unitA = new Barracks();
            UnitCreater unitB = new Barracks();

            Unit marineA = unitA.CreateUnit("마린A");
            Unit marineB = unitA.CreateUnit("마린B");

            marineA.Move($"{marineA} : 12시 미네랄 뒤");
            marineB.Move($"{marineB} : {marineA.Name} 방향으로 이동중");
            marineA.Attack(marineB);
        }
    }
}
