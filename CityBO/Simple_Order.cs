using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityBO
{
    class Simple_Order
    {
        
        

        public void formOpen(string num)
        {
            DateTime orderCreated, paidTime, timeLimit;
            String orderNum, email, phoneNum, price = null, toPay = null, paidSum = null, titul;
            int iPrice = Convert.ToInt32(price), iToPay = Convert.ToInt32(toPay), iPaidSum = Convert.ToInt32(paidSum), state = -1;

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
