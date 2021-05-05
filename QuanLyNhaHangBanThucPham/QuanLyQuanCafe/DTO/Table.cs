using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class Table
    {
        public Table(int id, string names, string status)
        {
            this.ID = id;
            this.Names = names;
            this.Status = status;
        }


        public Table(DataRow row) 
        {
            this.ID = (int)row["id"];
            this.Names = row["names"].ToString();
            this.Status = row["status"].ToString();
        }


        private string status;

        public string Status 
        {
            get { return status; }
            set { status = value; } 
        }

        private string names;

        public string Names 
        {
            get { return names; }
            set { names = value; } 
        }

        private int iD;

        public int ID 
        {
            get { return iD; }
            set { iD = value; }
        }  
    }
}
