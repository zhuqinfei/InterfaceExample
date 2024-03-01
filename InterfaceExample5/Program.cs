using System;

namespace InterfaceExample5
{
    /// <summary>
    /// 这是一个紧耦合，需要重新修改 PowerSupply，才能往下判断等。等我们设计一个类的时候，
    /// 尽里别再去修改他了，所以需要去做解耦合
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            DeskFan deskFan = new DeskFan(new PowerSupply());

            Console.WriteLine(deskFan.Work());
;        }
    }
    class PowerSupply
    {
        public int GetPower()
        {
            return 100;
        }
    }
    class DeskFan
    {
        private PowerSupply _powerSupply;
        public DeskFan(PowerSupply powerSupply)
        {
            this._powerSupply = powerSupply;
        }
        public string Work()
        {
            int power = _powerSupply.GetPower();
            if (power<0)
            {
                return "Won't work";
            }
            else if (power<100)
            {
                return "Slow";
            }
            else if (power < 200)
            {
                return "Work fine";
            }
            else
            {
                return "Warning";
            }
        }
    }
}
