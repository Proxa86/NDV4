﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data;
using System.IO;

namespace NDV4
{
    class OpenFile
    {

        public SQLiteConnection DbConn { get; set; }

        public SQLiteCommand SqlCmd { get; set; }

        public string PathLocation { get; set; }

        public Button BAnalysis { get; set; }

        public string DbFileName { get; set; }
        public static Form1 form { get; set; }

        public OpenFile() {
            DbConn = new SQLiteConnection();
            SqlCmd = new SQLiteCommand();
        }

        public OpenFile (Button bAnalysis, Form1 f)
        {
            DbConn = new SQLiteConnection();
            SqlCmd = new SQLiteCommand();
            BAnalysis = bAnalysis;
            form = f;
        }

        public void openFileDB()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "sqlite files (*.sqlite)|*.sqlite|All files (*.*)|*.*";

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                DbFileName = Path.GetFileName(ofd.FileName);
                PathLocation = Path.GetDirectoryName(ofd.FileName);

                
                DbConn = new SQLiteConnection("Data Source=" + PathLocation + "\\" + DbFileName + ";Version=3;");
                DbConn.Open();
                SqlCmd.Connection = DbConn;

                if (DbConn.State != ConnectionState.Open)
                {
                    MessageBox.Show("Open connection with database");
                    return;
                }
                form.Text = Path.GetFileNameWithoutExtension(DbFileName);
                form.Refresh();

            }
            else
            {
                return;
            }

            InfoOpenProject.DbConn = DbConn;
            InfoOpenProject.SqlCmd = SqlCmd;
            InfoOpenProject.PathLocation = Path.GetDirectoryName(ofd.FileName);
            MessageBox.Show("Open DB - OK");
            BAnalysis.Enabled = true;
        }
    }
}
