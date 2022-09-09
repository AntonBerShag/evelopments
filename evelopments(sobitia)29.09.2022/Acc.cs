using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evelopments_sobitia_29._09._2022 {

    internal class Acc {
        public delegate void AccHandler(string sender);

        public event AccHandler? Notify;

        public Acc(int sum) {
            Sum = sum;
            Notify?.Invoke($"На счет поступило: {sum}");
        }

        public int Sum { get; set; }

        public void Put(int sum) 
        { 
            Sum += sum;
            Console.WriteLine($"На счет поступило: " +
                $"{sum}");
        }

        public void Take(int sum) 
        {
            if (Sum >= sum) {
                Sum -= sum;
                Notify?.Invoke($"Со счета снято: {sum}");
            }
            else 
            {
                Notify?.Invoke($"Недостаточно средств.");
            }
        }
    }
}
