using System;

namespace InterfaceExample6
{
    /// <summary>
    /// 通过新增一个接口，来进行解耦合
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            DeskFan deskFan = new DeskFan(new PowerSupply());

            Console.WriteLine(deskFan.Work());
        }
    }
    interface IPowerSupply
    {
        int GetPower();
    }

    class PowerSupply: IPowerSupply
    {
        public int GetPower()
        {
            return 110;
        }
    }
    class DeskFan
    {
        private IPowerSupply _powerSupply;
        public DeskFan(IPowerSupply powerSupply)
        {
            this._powerSupply = powerSupply;
        }
        public string Work()
        {
            int power = _powerSupply.GetPower();
            if (power < 0)
            {
                return "Won't work";
            }
            else if (power < 100)
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
