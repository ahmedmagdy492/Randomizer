using Randomizer.Helpers;
using Randomizer.Models;
using Randomizer.Repository;
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
    public partial class MyThings : Form
    {
        private readonly UnitOfWork _unitOfWork;
        private List<string> _comparisonList;

        public MyThings()
        {
            InitializeComponent();

            _unitOfWork = new UnitOfWork();
        }

        private async void MyThings_Load(object sender, EventArgs e)
        {
            thingName.Focus();

            try
            {
                dataGridView1.DataSource = await _unitOfWork?.ThingsRepo?.GetAll();
                UpdateFont();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await Add();
        }

        #region Methods
        private async Task Add()
        {
            if (!string.IsNullOrWhiteSpace(thingName.Text))
            {
                try
                {
                    var thing = new Thing
                    {
                        Content = thingName.Text,
                    };

                    _unitOfWork?.ThingsRepo?.Create(thing);
                    await _unitOfWork?.SaveChangesAsync();

                    dataGridView1.DataSource = await _unitOfWork?.ThingsRepo?.GetAll();

                    thingName.Text = string.Empty;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public async Task Delete()
        {
            try
            {
                DialogResult dr = MessageBox.Show("هل انت متأكد من مسح هذا ؟", "تحذير", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if(dr == DialogResult.OK)
                {
                    string? id = dataGridView1?.SelectedRows[0]?.Cells["ID"]?.Value?.ToString();
                    var thing = await _unitOfWork?.ThingsRepo?.GetByID(id);

                    _unitOfWork.ThingsRepo?.Delete(thing);
                    await _unitOfWork.SaveChangesAsync();

                    dataGridView1.DataSource = await _unitOfWork?.ThingsRepo?.GetAll();
                }
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

        private async void thingName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                await Add();
            }
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);

            if (e.KeyCode == Keys.Tab)
            {
                thingName.Focus();
            }
        }

        private async void مسحالمحددToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await Delete();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if(dataGridView1.SelectedRows.Count == 0)
            {
                e.Cancel = true;
            }

            if (dataGridView1.SelectedRows.Count > 1)
            {
                اضافهللمقارنةToolStripMenuItem.Enabled = true;
            }
            else
            {
                اضافهللمقارنةToolStripMenuItem.Enabled = false;
            }
        }

        private void اضافهللمقارنةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_comparisonList == null)
                _comparisonList = new List<string>();

            foreach(DataGridViewRow row in dataGridView1.SelectedRows)
            {
                _comparisonList.Add(row.Cells["Content"].Value.ToString());
            }

            // TODO: generate the random number for the list and show it in a window
            int randomIndex = RandomGenerator.Generate(_comparisonList.Count);

            MessageBox.Show(_comparisonList[randomIndex], "تم أختيار");
            
            _comparisonList.Clear();
        }
    }
}
