using _10._3WinformsCArs.Services;

namespace _10._3WinformsCArs
{
    public partial class Form1 : Form
    {
        CRUD crud = new CRUD();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = crud.GetAllCars();
            btnSubmit.Enabled = false;
           

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtVIN.Clear();
            txtMAKE.Clear();
            txtMODEL.Clear();
            txtYEAR.Clear();
            txtPrice.Clear();
            btnSubmit.Enabled = true;

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtVIN.Text) && !string.IsNullOrEmpty(txtMAKE.Text))
            {
                var car = new Cars.Car
                {
                    VIN = txtVIN.Text,
                    Make = txtMAKE.Text,
                    Model = txtMODEL.Text,
                    Year = string.IsNullOrEmpty(txtYEAR.Text) ? 0 : int.Parse(txtYEAR.Text),
                    Price = string.IsNullOrEmpty(txtPrice.Text) ? 0f : float.Parse(txtPrice.Text)
                };
                crud.AddCar(car);
                dataGridView1.DataSource = crud.GetAllCars();
                btnSubmit.Enabled = false;
            }
            else
            {
                MessageBox.Show("VIN and Make are required fields.");
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            var selectedCar = (string)dataGridView1.CurrentRow.Cells["VIN"].Value;
            crud.DeleteCar(selectedCar);
            dataGridView1.DataSource = crud.GetAllCars();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var selectedCar = (string)(dataGridView1.CurrentRow.Cells["VIN"].Value);
            var car = crud.FindCar(selectedCar);
            if (car != null)
            {
                txtVIN.Text = car.VIN;
                txtMAKE.Text = car.Make;
                txtMODEL.Text = car.Model;
                txtYEAR.Text = car.Year.ToString();
                txtPrice.Text = car.Price.ToString();
                btnSubmit.Enabled = false;
                
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtVIN.Text) && !string.IsNullOrEmpty(txtMAKE.Text))
            {
                var car = new Cars.Car
                {
                    VIN = txtVIN.Text,
                    Make = txtMAKE.Text,
                    Model = txtMODEL.Text,
                    Year = string.IsNullOrEmpty(txtYEAR.Text) ? 0 : int.Parse(txtYEAR.Text),
                    Price = string.IsNullOrEmpty(txtPrice.Text) ? 0f : float.Parse(txtPrice.Text)
                };
                crud.UpdateCar(car);
                dataGridView1.DataSource = crud.GetAllCars();
                btnSubmit.Enabled = false;
            }
            else
            {
                MessageBox.Show("VIN and Make are required fields.");
            }
        }
    }
}
