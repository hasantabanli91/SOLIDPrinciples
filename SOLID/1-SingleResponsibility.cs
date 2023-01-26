using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace SOLID
{
    public class SingleResponsibility
    {
        public void SingleResponseInCafe()
        {
            string order = OrderService.CreateOrder();
            Console.WriteLine(order);

            bool paymentSituation = PaymentService.MakePayment();
            if (paymentSituation)
            {
                Console.WriteLine("    Payment received");
            }
        }
    }
    public static class OrderService
    {
        public static string CreateOrder()
        {
            string Order = "    Order is getting ready";
            //Code to Create Order
            return Order;
        }
    }
    public static class PaymentService
    {
        public static bool MakePayment()
        {
            //Code to Make Payment
            return true;
        }
    }
}
