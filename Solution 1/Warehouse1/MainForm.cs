using Membership;
using Warehouse;
using Catalog;

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
            dlg.ShowDialog();
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

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void txtProductID_TextChanged(object sender, EventArgs e)
        {

        }

        private void OnInsertProduct(object sender, EventArgs e)
        {
            int id = int.Parse(this.txtProductID.Text);
            string title = this.txtProductTitle.Text;
            string description = this.txtProductDescription.Text;
            float unitPrice = float.Parse(this.txtProductUnitPrice.Text);
            int quantity = int.Parse(this.txtProductQuantity.Text);


            Product theProduct = new Product
            {
                Id = id,
                Title = title,
                Description = description,
                UnitPrice = unitPrice,
                Quantity = quantity
            };


            //populating data into gridview
            this.allproducts.Add(theProduct);
            this.dataProductGridView.DataSource = null;
            this.dataProductGridView.DataSource = this.allproducts;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnFirst_Click(object sender, EventArgs e)
        {

        }
    }
}
