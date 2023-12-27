using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace SOLID
{
    // Classes with single responsibility are easier to design & implement
    // Improves readability as it is a single class per functionality which is much easier to explain and understand.
    // Improves testability as due to single functionality in a class it reduces complexity while writing unit test cases for a class.
    // It is easier to debug errors as well i.e. if there is an error in email functionality then you know which class to look for.
    // It also allows to reuse of the same code in other places at well i.e. if you build an email functionality class can same can be used for user registration, OTP over email, forgot passwords, etc.
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
