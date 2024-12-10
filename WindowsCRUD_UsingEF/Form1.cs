namespace WindowsCRUD_UsingEF
{
    public partial class Form1 : Form
    {
        private readonly IRepository<Dog> _dogRepository;
        public Form1(IRepository<Dog> dogRepository)
        {
            InitializeComponent();
            _dogRepository = dogRepository;
            LoadDogs();
        }
        private void LoadDogs()
        {
            var dogs = _dogRepository.GetAll();
            dataGridView1.DataSource = dogs.ToList();
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            var dog = new Dog
            {
                DogName = txtDogName.Text,
                Weight = Convert.ToDecimal(txtWeight.Text),
                 FavoriteFood= txtFavoriteFood.Text
                 
            };
            _dogRepository.Add(dog);
            LoadDogs();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDogs();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedId = Convert.ToInt32(txtId.Text);

                // Retrieve the dog by ID
                Dog dogToUpdate = _dogRepository.GetById(selectedId);
                if (dogToUpdate != null)
                {
                    // Update the properties
                    dogToUpdate.DogName = txtDogName.Text;
                    dogToUpdate.Weight = Convert.ToDecimal(txtWeight.Text);
                    dogToUpdate.FavoriteFood = txtFavoriteFood.Text;

                    // Call the repository to update the dog
                    _dogRepository.Update(dogToUpdate);

                    // Refresh the grid
                    LoadDogs();
                }
            }
            else
            {
                MessageBox.Show("Please select a row to update.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedId = Convert.ToInt32(txtId.Text);

                // Confirm deletion
                var result = MessageBox.Show("Are you sure you want to delete this record?",
                    "Delete Confirmation", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    // Call the repository to delete the dog by ID
                    _dogRepository.Delete(selectedId);

                    // Refresh the grid
                    LoadDogs();
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtId.Text = row.Cells["Id"].Value.ToString();
                txtDogName.Text = row.Cells["DogName"].Value.ToString();
                txtWeight.Text = row.Cells["Weight"].Value.ToString();
                txtFavoriteFood.Text = row.Cells["FavoriteFood"].Value.ToString();
            }
        }
    }
}
