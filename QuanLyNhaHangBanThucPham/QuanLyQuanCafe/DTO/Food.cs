using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class Food
    {
        public Food(int id, string names, int idCategory, float price)
        {
            this.ID = id;
            this.Names = names;
            this.IDCategory = idCategory;
            this.Price = price;
        }

        public Food(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Names = row["names"].ToString();
            this.IDCategory = (int)row["idCategory"];
            this.Price = (float)Convert.ToDouble(row["price"].ToString());
        }

        private int iD;

        public int ID 
        {
            get { return iD; }
            set { iD = value; } 
        }
        
        private string names;

        public string Names 
        {
            get { return names; }
            set { names = value; }
        }
        
        private int iDCategory;

        public int IDCategory 
        {
            get { return iDCategory; }
            set { iDCategory = value; } 
        }
        
        private float price;

        public float Price 
        {
            get { return price; }
            set { price = value; } 
        }
    }
}
