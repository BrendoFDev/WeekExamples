using System.Data;
using System.Text.RegularExpressions;

namespace Winforms
{
    public partial class Cadastro : Form
    {
        public DataTable dtPeople = new DataTable();
        private Banco banco = new Banco(); // 🔹 instância do banco

        public Cadastro()
        {
            InitializeComponent();
            LoadGrid();
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {
            
            dgvPeople.DataSource = dtPeople;
        }

        private void LoadGrid()
        {
            dtPeople.Columns.Add("Nome");
            dtPeople.Columns.Add("Idade");
            dtPeople.Columns.Add("Email");

            dtPeople = banco.LoadDGV(dtPeople);

            dgvPeople.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvPeople.DataSource = dtPeople;
        }

        private void bttRegister_Click(object sender, EventArgs e)
        {
            try
            {
                People people = new People();

                people.Name = txtName.Text;
                people.Email = txtEmail.Text;
                people.Age = Convert.ToInt32(txtAge.Text);

                Validate(people);

                // 🔹 insere no banco
                banco.InserirPessoa(people);

                // 🔹 adiciona no DataGridView
                AddPeopleIntoDataGridView(people);

                MessageBox.Show("Cadastro salvo com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddPeopleIntoDataGridView(People people)
        {
            var row = dtPeople.NewRow();

            row["Nome"] = people.Name;
            row["Idade"] = people.Age;
            row["Email"] = people.Email;

            dtPeople.Rows.Add(row);
            dgvPeople.DataSource = dtPeople;
        }

        private void Validate(People people)
        {
            Validator userValidator = new Validator();
            var result = userValidator.Validate(people);
            if (result.Errors.Any())
            {
                List<string> errors = result.Errors.Select(x => x.ErrorMessage).ToList();
                throw new Exception(string.Join(", \n ", errors));
            }
        }

        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}
