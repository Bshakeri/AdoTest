using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DourtalAdoDatabase01 
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Models.DatabaseContext oDatabaseContext = null;
            try
            {
                oDatabaseContext = new Models.DatabaseContext();

                Models.Person oPeson = new Models.Person();

                oPeson.Id = 5;
                oPeson.Age = 32;
                oPeson.FullName = "hamed";
                oPeson.IsSupervisor = true;

                oDatabaseContext.People.Add(oPeson);
                oDatabaseContext.SaveChanges();
           

            }
            catch (System.Exception ex)
            {

                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                if (oDatabaseContext != null)
                {
                    oDatabaseContext.Dispose();
                    oDatabaseContext = null;

                }
            }
        }

        

    }
     
    
}
