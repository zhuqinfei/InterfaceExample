using System;

namespace InterfaceExample4
{
    /// <summary>
    /// 这个例子给你说明了解耦合内容，也就是互相影响程度没有那么高，我们还是调用的手机的接口，
    /// 但是当其他品牌手机坏了，不影响另个一个品牌的手机的实例化
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            NoKiaPhone noKiaPhone = new NoKiaPhone();
            PhoneUser user = new PhoneUser(noKiaPhone);
            user.UsePhone();
        }
    }

    class PhoneUser
    {
        public IPhone _phone;
        public PhoneUser(IPhone phone)
        {
            this._phone = phone;
        }
        public void UsePhone()
        {
            this._phone.Dail();
            this._phone.PickUp();
            this._phone.PickUp();
            this._phone.Send();
        }
    }

    interface IPhone
    {
        void Dail();
        void PickUp();
        void Send();
        void Receive();
    }

    class NoKiaPhone : IPhone
    {
        public void Dail()
        {
            Console.WriteLine("Nokia calling...");
        }

        public void PickUp()
        {
            Console.WriteLine("Hello! This is Nokia");
        }

        public void Receive()
        {
            Console.WriteLine("Nokia message ring...");
        }

        public void Send()
        {
            Console.WriteLine("Nokia");
        }
    }
    class EricssonPhone : IPhone
    {
        public void Dail()
        {
            Console.WriteLine("EricssonPhone calling...");
        }

        public void PickUp()
        {
            Console.WriteLine("Hello! This is EricssonPhone");
        }

        public void Receive()
        {
            Console.WriteLine("EricssonPhone message ring...");
        }

        public void Send()
        {
            Console.WriteLine("EricssonPhone");
        }
    }
}
