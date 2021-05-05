using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class Category
    {
        public Category(int id, string names)
        {
            this.ID = id;
            this.Names = names;
        }

        public Category(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Names = row["names"].ToString();
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
