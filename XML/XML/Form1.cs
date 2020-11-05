using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace XML
{
    public partial class Form1 : Form
    {
        List<Product> listProduct = new List<Product>();
        List<Order> listOrder = new List<Order>();
        List<OrderDetails> listOrderD = new List<OrderDetails>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpenOrders_Click(object sender, EventArgs e)
        {
            openOrders.ShowDialog();
        }

        private void btnOpenProducts_Click(object sender, EventArgs e)
        {
            openProducts.ShowDialog();
        }

        private void openOrders_FileOk(object sender, CancelEventArgs e)
        {
            String filePath;
            String[] Values;
            String[] pathSplit;
            String fileName;
            Int32 count = 0;

            pathSplit = openOrders.FileName.ToString().Split('\\');

            fileName = pathSplit[pathSplit.Length - 1];

            do
            {
                MessageBox.Show("Incorrect file name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //openProducts.ShowDialog();
            }
            while (fileName != "Products.csv");
            if (listProduct.Count != 0)
            {
                filePath = openOrders.FileName.ToString();
                StreamReader sr = new StreamReader(filePath);

                while (sr.EndOfStream == false)
                {

                    String Line = sr.ReadLine();
                    Values = Line.Split(';');
                    if (count != 0)
                    {
                        Order or = new Order(Convert.ToInt32(Values[0]), DateTime.Parse(Values[1].ToString()));
                        listOrder.Add(or);
                    }
                    count++;
                }
                sr.Close();

                count = 0;
                filePath = "";
                foreach (String s in pathSplit)
                {
                    if (count != pathSplit.Length - 1)
                    {
                        filePath += s + '\\';
                        count++;
                    }
                }
                filePath += "OrderDetails.csv";
                count = 0;

                StreamReader sr1 = new StreamReader(filePath);

                while (sr1.EndOfStream == false)
                {

                    String Line = sr1.ReadLine();
                    Values = Line.Split(';');
                    if (count != 0)
                    {
                        OrderDetails od = new OrderDetails(Convert.ToInt32(Values[0]), Convert.ToInt32(Values[1]), Convert.ToInt32(Values[2]), Convert.ToInt32(Values[3]));
                        listOrderD.Add(od);
                    }
                    count++;
                }
                sr1.Close();
                loadData();
            }


        }

        private void openProducts_FileOk(object sender, CancelEventArgs e)
        {
            String filePath;
            String[] Values;
            String[] pathSplit;
            String fileName;
            Int32 count = 0;



            pathSplit = openProducts.FileName.ToString().Split('\\');

            fileName = pathSplit[pathSplit.Length - 1];

            do
            {
                MessageBox.Show("Incorrect file name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //openProducts.ShowDialog();
            } while (fileName != "Products.csv");
            if (listProduct.Count != 0)
            {
                filePath = openProducts.FileName.ToString();
                StreamReader sr = new StreamReader(filePath);

                while (sr.EndOfStream == false)
                {
                    String Line = sr.ReadLine();
                    Values = Line.Split(';');
                    if (count != 0)
                    {
                        Product pr = new Product(Convert.ToInt32(Values[0]), Values[1].ToString(), Convert.ToInt32(Values[2]), Convert.ToInt32(Values[3]), Convert.ToInt32(Values[4]));
                        listProduct.Add(pr);
                    }
                    count++;
                }
                sr.Close();
                loadData();
            }


        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openProducts.ShowDialog();
        }

        private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openOrders.ShowDialog();
        }

        public void loadData()
        {
            foreach(Order o in listOrder)
            {
                lsbxOrder.Items.Add(o);
            }

            foreach (OrderDetails od in listOrderD)
            {
                lsbxOrderD.Items.Add(od);
            }

            foreach (Product p in listProduct)
            {
                lsbxProducts.Items.Add(p);
            }
        }
    }
}
