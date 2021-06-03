using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PersonnelManagement.Controller;

namespace PersonnelManagement
{
	
	public partial class TableOverview : Form
	{
		//public string TableName { get; set; }
		Query controller;
		
		public TableOverview()
		{
			
			InitializeComponent();
			
		}

		public void TableOverview_Load(object sender, EventArgs e)
		{

			/*DataGridView dataGridView1 = new DataGridView();
			dataGridView1.Location = new Point(12, 37);
			dataGridView1.Width = 665;
			dataGridView1.Height = 300;
			//dataGridView1.DataSource = ds;
			dataGridView1.DataMember = "Adv_table";
			this.Controls.Add(dataGridView1);*/
			//controller.UpdateTable(TableName);


		}

		public void TableOverview_FormClosed(object sender, FormClosedEventArgs e)
		{

		}


	}
}
