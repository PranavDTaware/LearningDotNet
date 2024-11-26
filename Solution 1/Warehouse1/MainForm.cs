using Membership;
using Warehouse;
using Catalog;
using System.Runtime.Serialization.Formatters.Binary;

namespace Warehouse1
{
    public partial class MainForm1 : Form
    {

        private List<Product> allproducts = new List<Product>();
        public MainForm1()
        {
            InitializeComponent(); // code is written in seperate designer.cs file

            LoginForm frm = new LoginForm();
            frm.ShowDialog();
        }

        private void OnFileExit(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OnFileOpen(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.ShowDialog();
        }

        private void OnFileSaveAs(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                string fileName = dlg.FileName;
                FileStream stream = new FileStream(fileName, FileMode.OpenOrCreate);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(stream, allproducts);
            }
        }

        private void OnToolsSignIn(object sender, EventArgs e)
        {
            LoginForm frm = new LoginForm();
            frm.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtProductID_TextChanged(object sender, EventArgs e)
        {

        }

        private void OnInsertProduct(object sender, EventArgs e)
        {

            //get data from controls and store to variable
            int id = int.Parse(this.txtProductID.Text);
            string title = this.txtProductTitle.Text;
            string description = this.txtProductDescription.Text;
            float unitPrice = float.Parse(this.txtProductUnitPrice.Text);
            int quantity = int.Parse(this.txtProductQuantity.Text);

            //Create instance of Product based on data recieved
            Product theProduct = new Product
            {
                Id = id,
                Title = title,
                Description = description,
                UnitPrice = unitPrice,
                Quantity = quantity
            };


            //add product into list

            this.allproducts.Add(theProduct);

            //bind list to datagridview
            this.dataProductGridView.DataSource = null;
            this.dataProductGridView.DataSource = this.allproducts;
        }


        private int current = 0;


        private void OnFirst(object sender, EventArgs e)
        {
            this.current = 0;
            Display();
        }

        private void OnPrevious(object sender, EventArgs e)
        {
            if(this.current != 0)
            this.current = current - 1;
            Display();
        }

        private void OnNext(object sender, EventArgs e)
        {
            if(this.current != allproducts.Count)
            this.current = current + 1;
            Display();
        }

        private void OnLast(object sender, EventArgs e)
        {
            this.current = allproducts.Count - 1;
            Display();
        }

        private void Display()
        {
            Product theProduct = allproducts [current];

            this.txtProductID.Text = theProduct.Id.ToString();
            this.txtProductTitle.Text = theProduct.Title.ToString();
            this.txtProductDescription.Text = theProduct.Description.ToString();
            this.txtProductUnitPrice.Text = theProduct.UnitPrice.ToString();
            this.txtProductQuantity.Text = theProduct.Quantity.ToString();
        }
    }
}
