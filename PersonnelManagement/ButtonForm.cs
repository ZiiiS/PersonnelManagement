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

	public partial class ButtonForm : Form
	{
		Query controller;
		public ButtonForm()
		{
			InitializeComponent();
			controller = new Query(ConnectionString.ConnStr);
			

		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		public void StaffTableButton_Click(object sender, EventArgs e)
		{
			TableOverview TableOverview = new TableOverview();
			TableOverview.dataGridView1.DataSource = controller.UpdateTable("Сотрудники");
			TableOverview.ShowDialog();
		}

		private void TablePositionButton_Click(object sender, EventArgs e)
		{
			TableOverview TableOverview1 = new TableOverview();
			TableOverview1.dataGridView1.DataSource = controller.UpdateTable("Должность");
			TableOverview1.ShowDialog();
		}

		private void TableDepartmentButton_Click(object sender, EventArgs e)
		{
			TableOverview TableOverview = new TableOverview();
			TableOverview.dataGridView1.DataSource = controller.UpdateTable("Отдел");
			TableOverview.ShowDialog();
		}

		private void TableVacationButton_Click(object sender, EventArgs e)
		{
			TableOverview TableOverview = new TableOverview();
			TableOverview.dataGridView1.DataSource = controller.UpdateTable("Отпуска");
			TableOverview.ShowDialog();
		}

		private void TablePassDataButton_Click(object sender, EventArgs e)
		{
			TableOverview TableOverview = new TableOverview();
			TableOverview.dataGridView1.DataSource = controller.UpdateTable("Паспортные_данные_сотрудников");
			TableOverview.ShowDialog();

		}

		private void TableBusinessButton_Click(object sender, EventArgs e)
		{
			TableOverview TableOverview = new TableOverview();
			TableOverview.dataGridView1.DataSource = controller.UpdateTable("Сведения_о_командировках");
			TableOverview.ShowDialog();
		}

		private void TablePromotionButton_Click(object sender, EventArgs e)
		{
			TableOverview TableOverview = new TableOverview();
			TableOverview.dataGridView1.DataSource = controller.UpdateTable("Сведения_о_повышении_квалификации");
			TableOverview.ShowDialog();
		}

		private void TableRewardsButton_Click(object sender, EventArgs e)
		{
			TableOverview TableOverview = new TableOverview();
			TableOverview.dataGridView1.DataSource = controller.UpdateTable("Сведения_о_поощрениях");
			TableOverview.ShowDialog();
		}

		private void TableBenefitsButton_Click(object sender, EventArgs e)
		{
			TableOverview TableOverview = new TableOverview();
			TableOverview.dataGridView1.DataSource = controller.UpdateTable("Социальные_льготы");
			TableOverview.ShowDialog();
		}

		private void TableFiringButton_Click(object sender, EventArgs e)
		{
			TableOverview TableOverview = new TableOverview();
			TableOverview.dataGridView1.DataSource = controller.UpdateTable("Увольнения");
			TableOverview.ShowDialog();
		}

		private void TableStaffButton_Click(object sender, EventArgs e)
		{
			TableOverview TableOverview = new TableOverview();
			TableOverview.dataGridView1.DataSource = controller.UpdateTable("Штатное_расписание");
			TableOverview.ShowDialog();
		}
	}
}
