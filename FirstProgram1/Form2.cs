using DomainLayer.Models;
using InfastructureLayer.Repositories;
using MaterialSkin.Controls;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstProgram1
{
   
    public partial class Form2 : MaterialForm
    {

        public readonly IProgramRepository? dbContext;
        internal Form1 Form1;

        public Form2(IProgramRepository? repository)
        {
            InitializeComponent();
            this.dbContext = repository;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void materialTextBox21_Click(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {

            if (Form1.isEdit)
            {
                Form1.ProgramEntity.ProgramName = textBoxProgramName.Text;
                dbContext.Update
            }
            else
            {
                var entity = new DomainLayer.Models.Program
                {

                    ProgramName = textBoxProgramName.Text,
                    Description = textBoxProgramDescription.Text,
                    Department = textBoxProgramDepartment.Text,
                };

                dbContext.Add(entity);

            }


            
            dbContext.Save();
            MessageBox.Show("Program has been added successfully.", "Adding Program", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Hide();
            Form1.getPrograms();
        }
    }
}
