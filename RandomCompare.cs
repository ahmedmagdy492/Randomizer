using Randomizer.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Randomizer
{
    public partial class RandomCompare : Form
    {
        private readonly List<string> _compareList;

        public RandomCompare()
        {
            InitializeComponent();

            _compareList = new List<string>();
        }

        private void RandomCompare_Load(object sender, EventArgs e)
        {
            thingName.Focus();

            UpdateFont();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        #region Methods
        private void Add()
        {
            if (!string.IsNullOrWhiteSpace(thingName.Text))
            {
                _compareList.Add(thingName.Text);

                dataGridView1.DataSource = _compareList.Select(val => new { Content = val }).ToList();

                thingName.Text = string.Empty;

                thingName.Focus();

                if (_compareList.Count > 0)
                {
                    btnAutoSelect.Enabled = true;
                }
            }
        }

        private void Delete()
        {
            try
            {
                _compareList.Remove(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());

                dataGridView1.DataSource = _compareList.Select(val => new { Content = val }).ToList();

                if (_compareList.Count == 0)
                    btnAutoSelect.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateFont()
        {
            //Change cell font
            foreach (DataGridViewColumn c in dataGridView1.Columns)
            {
                if (c.Index == 0)
                    c.Visible = false;
                c.DefaultCellStyle.Font = new Font("Arial", 24, GraphicsUnit.Pixel);
            }
        }
        #endregion

        private void thingName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Add();
            }
        }

        private void btnAutoSelect_Click(object sender, EventArgs e)
        {
            int randomIndex = RandomGenerator.Generate(_compareList.Count);

            MessageBox.Show(_compareList[randomIndex], "تم أختيار");
        }

        private void مسحالمحددToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                مسحالمحددToolStripMenuItem.Enabled = true;
            }
            else
            {
                مسحالمحددToolStripMenuItem.Enabled = false;
            }
        }
    }
}
