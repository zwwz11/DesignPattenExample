using DesignPattenExample.AbstractFactory;
using DesignPattenExample.Adapter;
using DesignPattenExample.Decorator;
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
            RunDecoratorPatten();
        }

        /// <summary>
        /// 싱글톤 패턴 예제 
        /// </summary>
        static void RunSingletonPatten()
        {
            // 하나의 객체를 전역으로 관리하기 위한 패턴

            SingletonExample singletonA = SingletonExample.Instance();
            singletonA.Name = "A로 설정";
            Console.WriteLine($"singletonA.Name = {singletonA.Name}");


            SingletonExample singletonB = SingletonExample.Instance();
            Console.WriteLine($"singletonB.Name = {singletonB.Name}");


            SingletonExample singletonC = SingletonExample.Instance();
            Console.WriteLine($"singletonC.Name = {singletonC.Name}");
        }

        /// <summary>
        /// 팩토리 메서드 패턴 예제
        /// </summary>
        static void RunFactoryMethodPatten()
        {
            /*
             * 정의.
             * 객체를 생성하기 위한 인터페이스를 정의, 클래스의 인스턴스를 만드는 행위를 서브 클래스에게 위임한다.
             * 객체의 생성을 한군데에서 관리 할 수 있다.
             * 
             * 코드 설명.
             * 1. UnitCreater 클래스는 유닛 객체를 반환하는 인터페이스를 가진다.
             * 2. UnitCreater를 상속받은 클래스는 각자 생성할 객체가 정의되어있다.
             * 3. UnitCreater에서 생성될 객체는 Unit이란 인터페이스를 가진다.
             * 
             */
            UnitCreater unitA = new Barracks();
            UnitCreater unitB = new Barracks();

            FactoryMethod.Unit marineA = unitA.CreateUnit("마린A");
            FactoryMethod.Unit marineB = unitA.CreateUnit("마린B");

            marineA.Move($"{marineA} : 12시 미네랄 뒤");
            marineB.Move($"{marineB} : {marineA.Name} 방향으로 이동중");
            marineA.Attack(marineB);
        }

        /// <summary>
        /// 추상 팩토리 패턴 예제
        /// </summary>
        static void RunAbstractFactoryPatten()
        {
            /*
             * 정의.
             * 구체적인 클래스를 명시하지 않고도 연관되어 있거나 의존적인 객체 패밀리 생성을 위한 인터페이스를 제공한다.
             * 
             * 코드 설명.
             * 1. Tribe(종족) 클래스는 생성할 건물을 인터페이스로 가진다.
             * 2. Tribe 클래스를 상속받은 객체는 각자 생성할 건물이 정의되어있다.
             * 3. 즉, 종족을 상속받은 객체는 어떤 건물을 생성할 수 있는지에 대한 패밀리를 가진다.
             * 
             */
            Tribe tribeA = new Terran();
            MainCenterBuilding mainCenterBuildingA = tribeA.CreateMainCenterBuilding();
            PopulationBuilding populationBuildingA = tribeA.CreatePopulationBuilding();
            populationBuildingA.Interact(mainCenterBuildingA);

            Worker workerA = mainCenterBuildingA.CreateWorker();
            workerA.DigMinerals();

            Console.WriteLine();

            Tribe tribeB = new Protoss();
            MainCenterBuilding mainCenterBuildingB = tribeB.CreateMainCenterBuilding();
            PopulationBuilding populationBuildingB = tribeB.CreatePopulationBuilding();
            populationBuildingA.Interact(mainCenterBuildingB);


            Worker workerB = mainCenterBuildingB.CreateWorker();
            workerB.DigMinerals();
            
        }

        /// <summary>
        /// 어댑터 패턴 예제
        /// </summary>
        static void RunAdapterPatten()
        {
            /*
             * 정의.
             * 한 클래스의 인터페이스를 클라이언트에서 사용하고자 하는 다른 인터페이스로 변환한다.
             * 인터페이스의 호환성 문제 때문에 같이 쓸 수 없는 클래스들을 연결해서 쓸 수 있다.
             * 
             * 코드 설명.
             * NewUnit이란 새로운 유닛이 등장.
             * 기존 유닛(OldUnit)과 새로운 유닛은 인터페이스 호환이 안됨.
             * 그래서 Unit이라는 객체를 새로 추가. NewUnit을 상속받음
             * Unit은 NewUnit의 인터페이스를 그대로 받으나 반환은 기존 OldUnit의 기능을 사용
             * 결과적으로 OldUnit의 소스를 수정할 필요없이 새로운 인터페이스를 그대로 사용할 수 있게된다.
             * 
             */

            NewUnit newUnit = new NewUnit();
            NewUnit oldUnit = new Adapter.Unit();

            newUnit.Move();
            oldUnit.Move();
        }

        /// <summary>
        /// 데코레이터 패턴
        /// </summary>
        static void RunDecoratorPatten()
        {
            /*
            * 정의.
            * 객체의 결합을 통해 기능을 동적으로 유연하게 확장 할 수 있도록 해주는 패턴
            * 기본 기능에 데코레이터 클래스를 통해 추가 기능을 조합하는 방식
            * 
            * 코드 설명.
            * Beverage는 이름을 재정의하고 가격을 무조건 반환해야하는 구조임.
            * Decorator은 이름을 무조건 재정의 해야함
            * Espresso객체는 Beverage를 상속받아 가격과 이름이 정해짐
            * Water, Milk, WhippedCream 객체는 Decorator객체를 상속받아 무조건 이름과 가격을 재정의해야하며
            * 이 과정에서 커피가 만들어지는 과정처럼 보이게 기능을 구현할 수 있음.
            * 
            * 에스프레소(1500원)에 + 물(500원추가) + 우유(500원 추가) + 휘핑크림(500원 추가)
            */
            Beverage espresso = new Espresso();
            Beverage americano = new Water(espresso);
            Beverage cafeLatte = new Milk(americano);
            Beverage cafeMocha = new WhippedCream(cafeLatte);

            Console.WriteLine($"{cafeMocha.GetDescription()}, {cafeMocha.Cost()}");
        }
    }
}
