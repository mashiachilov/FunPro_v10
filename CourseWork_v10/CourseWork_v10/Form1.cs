using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork_v10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tb_ChildBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            SaveBtn();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveBtn();
        }
        private void SaveBtn()
        {
            if(this.Validate())
            {
                try
                {
                    this.tb_ChildBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.childrenDataSet);
                    MessageBox.Show("Your changes has been saved");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'childrenDataSet.tb_ChildCategory' table. You can move, or remove it, as needed.
                this.tb_ChildCategoryTableAdapter.Fill(this.childrenDataSet.tb_ChildCategory);
                // TODO: This line of code loads data into the 'childrenDataSet.tb_Child' table. You can move, or remove it, as needed.
                this.tb_ChildTableAdapter.Fill(this.childrenDataSet.tb_Child);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }
        //moving buttons 
        private void btnFirst_Click(object sender, EventArgs e)
        {
            tb_ChildBindingSource.MoveFirst();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            tb_ChildBindingSource.MovePrevious();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tb_ChildBindingSource.MoveNext();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            tb_ChildBindingSource.MoveLast();
        }
        //enable disable button in the end and in the beginning of the row
        private void EnableDisableBtn()
        {
            if(tb_ChildBindingSource.Position == 0)
            {
                btnFirst.Enabled = false;
                btnPrevious.Enabled = false;
            }
            else
            {
                btnFirst.Enabled = true;
                btnPrevious.Enabled = true;
            }
            if(tb_ChildBindingSource.Position == tb_ChildBindingSource.Count - 1)
            {
                btnNext.Enabled = false;
                btnLast.Enabled = false;
            }
            else
            {
                btnNext.Enabled = true;
                btnLast.Enabled = true;
            }
        }

        private void tb_ChildBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            EnableDisableBtn();
        }
        //delete button if there is no information it will show message
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(tb_ChildBindingSource.Count == 0)
            {
                MessageBox.Show("There is no more information to delete");
            }
            else
            {
                var userResponse = MessageBox.Show("Do you want to delete this information?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(userResponse == DialogResult.Yes)
                {
                    tb_ChildBindingSource.RemoveCurrent();
                    MessageBox.Show("Information has been deleted");
                }
            }
        }
        //Filtering searching for names in dataset 
        private void tbxFilter_TextChanged(object sender, EventArgs e)
        {
            tb_ChildBindingSource.Filter = $"ChildName LIKE ('{tbxFilter.Text}%')";
        }
        //if name is empty it is not gonna let them do anything else
        private void childNameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(childNameTextBox.Text))
            {
                MessageBox.Show("Child Name cannot be empty");
                e.Cancel = true;
            }
        }

        private void tbxNewName_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(tbxNewName.Text))
            {
                MessageBox.Show("Child Name cannot be empty");
                e.Cancel = true;
            }
        }
        // asking if they are any changes before closing
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(Validate())
            {
                this.tb_ChildBindingSource.EndEdit();
                if(childrenDataSet.HasChanges())
                {
                    if ((MessageBox.Show("Do you want to save unsaved changes?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                    {
                        SaveBtn();
                    }
                    
                }
            }
            else
            {
                e.Cancel = true;
            }
        }
        ///Add buttton
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedCategory = ((DataRowView)cmbNewCategory.SelectedItem).Row;
                childrenDataSet.tb_Child.Addtb_ChildRow(
                    tbxNewName.Text,
                    tbxNewAddress.Text,
                    dtpNewDB.Value,
                    Convert.ToInt32(nudNewWeight.Value),
                    (ChildrenDataSet.tb_ChildCategoryRow)selectedCategory
                    );
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
