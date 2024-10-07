using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DGVPrinterHelper;

namespace StudentManagementSystem
{
    public partial class PrintScoreForm : Form
    {
        DTO dto = new DTO();
        DGVPrinter printer = new DGVPrinter();
        public PrintScoreForm()
        {
            InitializeComponent();
        }

        private void PrintScoreForm_Load(object sender, EventArgs e)
        {
            showStudentList();
        }

        void showStudentList()
        {
            dataGrid_Student.ReadOnly = true;
            dataGrid_Student.DataSource = dto.getCustomStudentInfo();

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Search.Text))
            {
                MessageBox.Show("Enter letters to search.", "Search Item", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                List<DTO> studentInfos = dto.searchStudentInfo(txt_Search.Text);
                dataGrid_Student.DataSource = studentInfos;
                txt_Search.Text = "";
            }
        }

        private void btn_ShowAll_Click(object sender, EventArgs e)
        {
            showStudentList();
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            //We need DGVprinter helper for print pdf file
            printer.Title = "Ludwig-Geißler-Schule Student Info List";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Kazemi-Printer";
            printer.FooterSpacing = 10;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintDataGridView(dataGrid_Student);
        }

        private void dataGrid_Student_Click(object sender, EventArgs e)
        {
            string searchItem = dataGrid_Student.CurrentRow.Cells[0].Value.ToString();
            searchItem += dataGrid_Student.CurrentRow.Cells[1].Value.ToString();

            List<DTO> studentInfos = dto.searchStudentInfo(searchItem);
            dataGrid_Student.DataSource = studentInfos;
        }
    }
}
