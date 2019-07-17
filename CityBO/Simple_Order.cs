using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityBO
{
    class Simple_Order
    {
        
        

        public void formOpen(string num)
        {
            int price, toPay, paidSum;
            DateTime orderCreated, timeLimit;
            String orderNum, email, phoneNum;

            orderNum = num;

            OrderForm order = new OrderForm();
            order.MdiParent = MainFormBO.ActiveForm;
            order.OrderNumber = orderNum;
            order.Show();
        }

        public Simple_Order(string num)
        {
            formOpen(num);
        }



    }
}
