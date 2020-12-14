using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Truyum.Models;

namespace Truyum.Repository
{
    public class CustomerRepository:ICustomerRepository
    {
        string connectionString = "Data Source=DESKTOP-FA0USB5\\SQLEXPRESS;Initial Catalog=TruYum;Persist Security Info=True;User ID=sa;Password=158x1a0530";

        public void AddToCart(Items item)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("INSERT INTO Cart(ItemName,Price,Category,Date,FreeDelivery,ItemId,Active) VALUES(@ItemName,@Price,@Category,@Date,@FreeDelivery,@ItemId,@Active)", con);
                command.Parameters.AddWithValue("@ItemName", item.ItemName);
                command.Parameters.AddWithValue("@Price", item.Price);
                command.Parameters.AddWithValue("@Category", item.Category);
                command.Parameters.AddWithValue("@Date", item.Date);
                command.Parameters.AddWithValue("@FreeDelivery", item.FreeDelivery);
                command.Parameters.AddWithValue("@ItemId", item.ItemId);
              

                command.Parameters.AddWithValue("@Active", item.Active);


                con.Open();
                command.ExecuteNonQuery();
                con.Close();
            }
        }
        public Items GetItemById(int? id)
        {

            Items item = new Items();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string sqlQuery = "SELECT * FROM Items WHERE ItemId= " + id;
                SqlCommand cmd = new SqlCommand(sqlQuery, con);

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    item.ItemId = Convert.ToInt32(rdr["ItemId"]);
                    item.ItemName = rdr["ItemName"].ToString();
                    item.Price = rdr["Price"].ToString();
                    item.Category = rdr["Category"].ToString();
                    item.FreeDelivery = rdr["FreeDelivery"].ToString();
                    item.Active = rdr["Active"].ToString();
                    item.Date = rdr["Date"].ToString();
                }
            }
            return item;

        }
        public void DeleteItemInCart(int id)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Cart WHERE CartId=@CartId", con);


                cmd.Parameters.AddWithValue("@CartId", id);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public List<Cart> GetItemsInCart()
        {
            List<Cart> cartList = new List<Cart>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("select * from Cart", con);
                con.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Cart cart = new Cart();
                    cart.CartId = Convert.ToInt32(reader["CartId"]);
                    cart.ItemName = reader["ItemName"].ToString();
                    cart.Price = reader["Price"].ToString();
                    cart.Category = reader["Category"].ToString();
                    cart.FreeDelivery = reader["FreeDelivery"].ToString();
                    cart.ItemId = Convert.ToInt32(reader["ItemId"]);
                    cart.Active = reader["Active"].ToString();
                    cart.Active = reader["Date"].ToString();

                    cartList.Add(cart);
                }
                con.Close();
            }
            return cartList;
        }

        public Cart GetCartItemById(int? cartId)
        {
            Cart cart = new Cart();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string sqlQuery = "SELECT * FROM Cart WHERE CartId= " + cartId;
                SqlCommand cmd = new SqlCommand(sqlQuery, con);

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    cart.CartId = Convert.ToInt32(rdr["CartId"]);
                    cart.ItemName = rdr["ItemName"].ToString();
                    cart.Price = rdr["Price"].ToString();
                    cart.Category = rdr["Category"].ToString();
                    cart.FreeDelivery = rdr["FreeDelivery"].ToString();
                    cart.ItemId = Convert.ToInt32(rdr["ItemId"]);
                    cart.Active = rdr["Active"].ToString();
                    cart.Date = rdr["Date"].ToString();
                }
            }
            return cart;
        }
    }
}
