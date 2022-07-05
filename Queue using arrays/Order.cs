using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Queue_using_arrays
{
    public partial class Order : Form
    {
        private orderQueue currentOrders = new orderQueue();
        private Random random = new Random();

        public Order()
        {
            InitializeComponent();          
        }

        private void placeOrderBtn_Click(object sender, EventArgs e)
        {
            int newOrder;

            newOrder = random.Next(100, 999);
            currentOrders.addOrder(newOrder);
            lastOrderPlaced.Text = newOrder.ToString();
        }

        private void collectOrderBtn_Click(object sender, EventArgs e)
        {
            int collectedOrder;
            
            collectedOrder = currentOrders.removeOrder();
            orderNumber.Text = "-";

            if (collectedOrder != -1)
            {
                lastOrderCollected.Text = collectedOrder.ToString();
            }

            orderReadyTimer.Interval = random.Next(5000, 15000);
            orderReadyTimer.Start();
        }

        private void orderReadyTimer_Tick(object sender, EventArgs e)
        {
            orderReadyTimer.Stop();

            if (currentOrders.nextOrder() != 0)
            {
                orderNumber.Text = currentOrders.nextOrder().ToString();
            }
            else
            {
                orderReadyTimer.Interval = random.Next(5000, 15000);
                orderReadyTimer.Start();
            }
        }
    }

    public class orderQueue
    {
        private int[] queueValues = new int[5];
        private int queueFront = 0;
        private int nextFree = 0;

        public void addOrder(int orderNumber)
        {
            if (nextFree < queueValues.Length)
            {
                queueValues[nextFree] = orderNumber;
                nextFree = nextFree + 1;
            }
            else
            {
                MessageBox.Show("Queue fully used");
            }
        }

        public int nextOrder()
        {
            return queueValues[queueFront];
        }

        public int removeOrder()
        {
            int orderRemoved = -1;

            if (queueFront < queueValues.Length)
            {
                if (queueValues[queueFront] == 0) 
                {
                    MessageBox.Show("Queue empty");
                }                
                    
                else
                {
                    orderRemoved = queueValues[queueFront];
                    queueFront = queueFront + 1;
                }
            }

            else
            {
                MessageBox.Show("End of queue");
            }

            return orderRemoved;
        }
    }
}
