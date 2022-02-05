﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataModelLayer.Models;

namespace AutomationSystem.AdminPanel
{
    public partial class frmNewsList : Form
    {
        Office_Automation_DatabaseEntities db = new Office_Automation_DatabaseEntities();
        public frmNewsList()
        {
            InitializeComponent();
        }

        private void frmNewsList_Load(object sender, EventArgs e)
        {
            txt_DateOn.Value = DateTime.Now.AddDays(-10);
            ShowAllNews(searchCondition());
        }

        private void ShowAllNews(string searchRecivedLetters)
        {
            var query = db.Database.SqlQuery<Vw_News>($"SELECT * FROM Vw_News WHERE 1=1 {searchRecivedLetters}");
            var result = query.ToList();

            dgv_NewsList.Rows.Clear();

            if (result.Count != 0)
            {
                dgv_NewsList.RowCount = result.Count;
                for (int i = 0; i <= result.Count - 1; i++)
                {
                    dgv_NewsList.Rows[i].Cells["col_NewsID"].Value = result[i].NewsID;

                    dgv_NewsList.Rows[i].Cells["col_NewsSubject"].Value = result[i].NewsSubject;
                    dgv_NewsList.Rows[i].Cells["col_NewsContext"].Value = result[i].NewsContext;
                    dgv_NewsList.Rows[i].Cells["col_NewsDate"].Value = result[i].NewsDate;
                    dgv_NewsList.Rows[i].Cells["col_FullName"].Value = result[i].FullName;
                    dgv_NewsList.Rows[i].Cells["col_NewsAttachment"].Value = result[i].NewsAttachmentFileName;
                }
                dgv_NewsList.TopLeftHeaderCell.Value = "رديف";
                for (int counter = 0; counter <= dgv_NewsList.Rows.Count - 1; counter++)
                {
                    dgv_NewsList.Rows[counter].HeaderCell.Value = (counter + 1).ToString();
                }
            }
            else
            {
                dgv_NewsList.Rows.Clear();
            }
        }

        private string searchCondition()
        {
            string dateIn = string.Format("{0:yyyy'/'MM'/'dd}", Convert.ToDateTime($"{txt_DateOn.Value.Year.ToString()}/{txt_DateOn.Value.Month.ToString()}/{txt_DateOn.Value.Day.ToString()}"));
            string dateTo = string.Format("{0:yyyy'/'MM'/'dd}", Convert.ToDateTime($"{txt_DateTo.Value.Year.ToString()}/{txt_DateTo.Value.Month.ToString()}/{txt_DateTo.Value.Day.ToString()}"));


            string searchString = $" AND NewsDate BETWEEN '{dateIn}' AND '{dateTo}'";

            if (txt_NewsSubject.Text != "")
            {
                searchString += $" AND NewsSubject LIKE '%{txt_NewsSubject.Text}%'";
            }

            if (txt_NewsContext.Text != "")
            {
                searchString += $" AND NewsContext LIKE '%{txt_NewsContext.Text}%'";
            }

            return searchString;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            ShowAllNews(searchCondition());
        }
    }
}
