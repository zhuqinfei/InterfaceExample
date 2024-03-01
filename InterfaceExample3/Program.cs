using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample3
{
    /// <summary>
    /// 这里就会有个紧耦合问题，因为 Engine一日发生问题，其中Car就不能正常运行了。这里例子简单一点，
    /// 但是实际中几百个代码和不同人分工不同很容易导致这种问题，所以要用到接口
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Engine engine = new Engine();
            Car car = new Car(engine);
            car.Run(3);
            Console.WriteLine(car.Speed);

        }
    }
    class Engine
    {
        public int RPM{ get; private set; }
        public void Work(int gas)
        {
            this.RPM = gas * 1000;
        }
    }
    class Car
    {
        public Engine _engine;
        public Car(Engine engine)
        {
            this._engine = engine;
        }

        public int Speed { get; private set; }
        public void Run(int gas)
        {
            _engine.Work(gas);
            this.Speed = _engine.RPM/100;
        }
    }
}
