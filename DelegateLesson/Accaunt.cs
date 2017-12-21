using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateLesson
{
    public delegate void AccountOperationHander(string message);
    public class Accaunt
    {
        private AccountOperationHander handler;
        public double Sum { get; set; }
        public void RegisterHender(AccountOperationHander hender)
        { 
            this.handler += hender;
        }
        public void UpRegisterHender(AccountOperationHander hender)
        {
            this.handler -= hender;
        }
        public void Add(int sum)
        {
            Sum += sum;
            if (handler != null)
            {
                handler.Invoke("vi add " + sum);
            }
        }
        public void Withdraw(int sum)
        {
            if(Sum<=sum)
            {
                Sum -=sum;
                if (handler != null)
                {
                    handler.Invoke("vi add" + sum);
                }

            }
            if (handler != null)
            {
                handler.Invoke("net " );
            }
        }
    }
}
