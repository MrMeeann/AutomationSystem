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
using AutomationSystem.Moduls;
using System.IO;

namespace AutomationSystem.UserPanel
{
    public partial class frmUserSendedLetters : Form
    {
        Office_Automation_DatabaseEntities db = new Office_Automation_DatabaseEntities();
        public frmUserSendedLetters()
        {
            InitializeComponent();
        }

        private void frmUserSendedLetters_Load(object sender, EventArgs e)
        {
            this.Left = 10;
            this.Top = 160;

            txt_DateOn.Value = DateTime.Now.AddDays(-10);
            ShowSendedLetters(searchCondition());
        }

        private void ShowSendedLetters(string searchRecivedLetters)
        {
            var query = db.Database.SqlQuery<Vw_ReciveLetter>($"SELECT * FROM Vw_ReciveLetter WHERE LetterDraftType = 2 AND LetterUserID = {PublicVariable.global_UserID} {searchRecivedLetters}");
            var result = query.ToList();

            dgv_SendedLetters.Rows.Clear();

            if (result.Count != 0)
            {
                dgv_SendedLetters.RowCount = result.Count;
                for (int i = 0; i <= result.Count - 1; i++)
                {
                    dgv_SendedLetters.Rows[i].Cells["col_LetterID"].Value = result[i].LetterID;

                    dgv_SendedLetters.Rows[i].Cells["col_LetterSubject"].Value = result[i].LetterSubject;
                    dgv_SendedLetters.Rows[i].Cells["col_LetterType"].Value = result[i].View_LetterType;
                    dgv_SendedLetters.Rows[i].Cells["col_LetterForceType"].Value = result[i].View_LetterForceType;
                    dgv_SendedLetters.Rows[i].Cells["col_LetterSecurityType"].Value = result[i].View_LetterSecurityType;
                    dgv_SendedLetters.Rows[i].Cells["col_LetterFollowingType"].Value = result[i].View_LetterFollowingType;
                    dgv_SendedLetters.Rows[i].Cells["col_LetterAttachmentType"].Value = result[i].View_LetterAttachmentType;
                    dgv_SendedLetters.Rows[i].Cells["col_LetterAnswerDeadLine"].Value = result[i].LetterAnswerDeadLine;
                    dgv_SendedLetters.Rows[i].Cells["col_LetterNo"].Value = result[i].LetterNo;
                    dgv_SendedLetters.Rows[i].Cells["col_LetterArchiveType"].Value = result[i].View_LetterArchiveType;
                    dgv_SendedLetters.Rows[i].Cells["col_LetterReciver"].Value = result[i].LetterReciverFullName;
                    dgv_SendedLetters.Rows[i].Cells["col_LetterReciverUserID"].Value = result[i].SentUserID;
                    dgv_SendedLetters.Rows[i].Cells["col_LetterReffrence"].Value = result[i].LetterReffrence;
                    dgv_SendedLetters.Rows[i].Cells["col_LetterSentDate"].Value = result[i].LetterSentDate;

                    dgv_SendedLetters.Rows[i].Cells["col_SecurityT"].Value = result[i].LetterSecurityType;
                    dgv_SendedLetters.Rows[i].Cells["col_ForceT"].Value = result[i].LetterForceType;
                    dgv_SendedLetters.Rows[i].Cells["col_ArchiveT"].Value = result[i].LetterArchiveType;
                    dgv_SendedLetters.Rows[i].Cells["col_AttachmentT"].Value = result[i].LetterAttachmentType;

                    if (Convert.ToInt16(dgv_SendedLetters.Rows[i].Cells["col_AttachmentT"].Value) == 1)
                    {
                        dgv_SendedLetters.Rows[i].Cells["col_LetterDownloadAttach"].Value = result[i].AttachFileName;
                    }

                    //SecurityType - Colors
                    if (Convert.ToInt16(dgv_SendedLetters.Rows[i].Cells["col_SecurityT"].Value) == 2)
                    {
                        dgv_SendedLetters.Rows[i].Cells["col_LetterSecurityType"].Style.BackColor = Color.Yellow;
                    }
                    else if (Convert.ToInt16(dgv_SendedLetters.Rows[i].Cells["col_SecurityT"].Value) == 3)
                    {
                        dgv_SendedLetters.Rows[i].Cells["col_LetterSecurityType"].Style.BackColor = Color.Red;
                    }

                    //ForceType - Colors
                    if (Convert.ToInt16(dgv_SendedLetters.Rows[i].Cells["col_ForceT"].Value) == 2)
                    {
                        dgv_SendedLetters.Rows[i].Cells["col_LetterForceType"].Style.BackColor = Color.Yellow;
                    }
                    else if (Convert.ToInt16(dgv_SendedLetters.Rows[i].Cells["col_ForceT"].Value) == 3)
                    {
                        dgv_SendedLetters.Rows[i].Cells["col_LetterForceType"].Style.BackColor = Color.Red;
                    }

                    //ArchiveType - Colors
                    if (Convert.ToInt16(dgv_SendedLetters.Rows[i].Cells["col_ArchiveT"].Value) == 2)
                    {
                        dgv_SendedLetters.Rows[i].Cells["col_LetterArchiveType"].Style.BackColor = Color.Plum;
                    }
                }
                dgv_SendedLetters.TopLeftHeaderCell.Value = "رديف";
                for (int counter = 0; counter <= dgv_SendedLetters.Rows.Count - 1; counter++)
                {
                    dgv_SendedLetters.Rows[counter].HeaderCell.Value = (counter + 1).ToString();
                }
            }
            else
            {
                dgv_SendedLetters.Rows.Clear();
            }
        }

        private string searchCondition()
        {
            string dateIn = string.Format("{0:yyyy'/'MM'/'dd}", Convert.ToDateTime($"{txt_DateOn.Value.Year.ToString()}/{txt_DateOn.Value.Month.ToString()}/{txt_DateOn.Value.Day.ToString()}"));
            string dateTo = string.Format("{0:yyyy'/'MM'/'dd}", Convert.ToDateTime($"{txt_DateTo.Value.Year.ToString()}/{txt_DateTo.Value.Month.ToString()}/{txt_DateTo.Value.Day.ToString()}"));


            string searchString = $" AND LetterSentDate BETWEEN '{dateIn}' AND '{dateTo}'";

            if (txt_LetterReciver.Text != "")
            {
                searchString += $" AND UserFullName LIKE '%{txt_LetterReciver.Text}%'";
            }

            if (txt_LetterNo.Text != "")
            {
                searchString += $" AND LetterNo LIKE '%{txt_LetterNo.Text}%'";
            }

            if (txt_LetterSubject.Text != "")
            {
                searchString += $" AND LetterSubject LIKE '%{txt_LetterSubject.Text}%'";
            }

            if (txt_LetterReffrence.Text != "")
            {
                searchString += $" AND LetterReffrence LIKE '%{txt_LetterReffrence.Text}%'";
            }

            //SecurityType - Search
            if (rdb_LetterSecurity_Normal.Checked == true)
            {
                searchString += " AND LetterSecurityType = 1";
            }
            else if (rdb_LetterSecurity_Confidential.Checked == true)
            {
                searchString += " AND LetterSecurityType = 2";
            }
            else if (rdb_LetterSecurity_Secretive.Checked == true)
            {
                searchString += " AND LetterSecurityType = 3";
            }

            //ForcedType - Search
            if (rdb_LetterForceType_Normal.Checked == true)
            {
                searchString += " AND LetterForceType = 1";
            }
            else if (rdb_LetterForceType_Immediate.Checked == true)
            {
                searchString += " AND LetterForceType = 2";
            }
            else if (rdb_LetterForceType_Posthaste.Checked == true)
            {
                searchString += " AND LetterForceType = 3";
            }

            //ArchivedType - Search
            if (rdb_LetterArchiveType_Archived.Checked == true)
            {
                searchString += " AND LetterArchiveType = 2";
            }
            else if (rdb_LetterArchiveType_NotArchived.Checked == true)
            {
                searchString += " AND LetterArchiveType = 1";
            }

            //LetterType - Search
            if (rdb_LetterType_Letter.Checked == true)
            {
                searchString += " AND LetterType = 1";
            }
            else if (rdb_LetterType_ReplyLetter.Checked == true)
            {
                searchString += " AND LetterType = 2";
            }

            //LetterAttachment - Search
            if (rdb_LetterAttachmentType_Yes.Checked == true)
            {
                searchString += " AND LetterAttachmentType = 1";
            }
            else if (rdb_LetterAttachmentType_No.Checked == true)
            {
                searchString += " AND LetterAttachmentType = 2";
            }

            //LetterFollowing - Search
            if (rdb_LetterFollowingType_Yes.Checked == true)
            {
                searchString += " AND LetterFollowingType = 1";
            }
            if (rdb_LetterFollowingType_No.Checked == true)
            {
                searchString += " AND LetterFollowingType = 2";
            }

            return searchString;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            ShowSendedLetters(searchCondition());
        }

        private void dgv_SendedLetters_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_SendedLetters.CurrentCell.ColumnIndex.Equals(14) && e.RowIndex != -1)
            {
                if (dgv_SendedLetters.CurrentCell != null && dgv_SendedLetters.CurrentCell.Value != null)
                {
                    int get_LetterID = Convert.ToInt32(dgv_SendedLetters.CurrentRow.Cells["col_LetterID"].Value);
                    var queryFileName = (from FN in db.AttachmentFiles where FN.AttachLetterID == get_LetterID select FN).ToList();
                    saveAttachmentFile(saveAttachFileDialog, dgv_SendedLetters, get_LetterID);
                }
            }
            else
            {
                MessageBox.Show(dgv_SendedLetters.CurrentCell.ToString());
            }
        }

        private void saveAttachmentFile(SaveFileDialog objSFD, DataGridView objGrid, int getLetterID)
        {
            try
            {
                string strID = objGrid.CurrentRow.Cells["col_LetterDownloadAttach"].Value.ToString();
                if (strID != null)
                {
                    var queryAttachment = (from AF in db.AttachmentFiles where AF.AttachLetterID == getLetterID select AF).ToList();

                    byte[] objData = (byte[])queryAttachment[0].AttachFileData;

                    objSFD.FileName = queryAttachment[0].AttachFileName;
                    objSFD.Title = "دريافت فايل الصاقي";

                    if (objSFD.ShowDialog() != DialogResult.Cancel)
                    {
                        string strFileToSave = objSFD.FileName;
                        FileStream objFileStream = new FileStream(strFileToSave, FileMode.Create, FileAccess.Write);
                        objFileStream.Write(objData, 0, objData.Length);
                        objFileStream.Close();

                        MessageBox.Show("فايل الصاقي باموفقيت دانلود شد", "دريافت فايل الصاق");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("در خواندن اطلاعات خطايي رخ داد", "پايگاه داده");
                return;
            }
        }
    }
}
