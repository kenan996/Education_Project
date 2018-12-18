using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Controller;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ModelDal dal = new ModelDal();

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_Turbo_azDataSet.Models' table. You can move, or remove it, as needed.
            this.modelsTableAdapter.Fill(this._Turbo_azDataSet.Models);
            ShowModels();
            ListMarks();
          
        }

        private void ShowModels()
        {
            dgwList.DataSource = dal.GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dal.Add(new Model
            {

                ModelName = txtModel.Text,

                ModelPrice = Convert.ToInt32(txtQiymeti.Text),

                ModelColor = txtRengi.Text,

                ModelYear = Convert.ToInt32(txtİli.Text),

                MarkaId = Convert.ToInt32(txtMarkaId.Text)

            });
            
            ShowModels();
            MessageBox.Show("Added!");
        }



        private void btnUpdate_Click(object sender, EventArgs e)
        {
            dal.Update(new Model
            {
                ModelId = Convert.ToInt32(dgwList.CurrentRow.Cells[0].Value.ToString()),

                ModelName = txtModel2.Text,

                ModelPrice = Convert.ToDecimal(txtQiymeti2.Text),

                ModelColor = txtRengi2.Text,

                ModelYear = Convert.ToInt32(txtİLi2.Text),
            
                MarkaId = Convert.ToInt32(txtMarkaId2.Text)
            });
            
            ShowModels();
            MessageBox.Show("Updated!");
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            dal.Delete(new Model
            {
                ModelId = Convert.ToInt32(dgwList.CurrentRow.Cells[0].Value)
            });

            ShowModels();
            MessageBox.Show("Deleted!");
        }

        private void SearchModels(string key)
        {

            //bunu belede yazmaq olardi

            //var result2 = dal.GetAll().Where(x => x.ModelName.ToLower().Contains(key.ToLower())).ToList();//bele yazilishda Listin icherisinnen Search Eleyir, key Sensitive dir

            var result = dal.GetName(key); //Database in icherisinnen Search Eleyir, Database KeySensitive deyil

            dgwList.DataSource = result;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SearchModels(txtSearch.Text);
        }

        //Write to ComboBox
        private void ListMarks()
        {
            using (Entities db = new Entities())
            {
                cbxMarks.DataSource = db.Marks.ToList();

                cbxMarks.DisplayMember = "MarkaName";

                cbxMarks.ValueMember = "MarkaId";
            }
        }

        private void ListModelsByMarks(int markId)
        {
            using (Entities db = new Entities())

            {


                dgwList.DataSource = db.Models.Where(x => x.MarkaId == markId).ToList();
            }

        }

        private void cbxMarks_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                ListModelsByMarks(Convert.ToInt32(cbxMarks.SelectedValue));
            }
            catch
            {

            }
        }

        private void dgwList_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtModel2.Text = dgwList.CurrentRow.Cells[1].Value.ToString();

            txtQiymeti2.Text = dgwList.CurrentRow.Cells[2].Value.ToString();

            txtRengi2.Text = dgwList.CurrentRow.Cells[3].Value.ToString();

            txtİLi2.Text = dgwList.CurrentRow.Cells[4].Value.ToString();

            txtMarkaId2.Text = dgwList.CurrentRow.Cells[5].Value.ToString();
        }

        
    }
}
