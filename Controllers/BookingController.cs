using Hotelbookingsystem.Models;
using Hotelbookingsystem.Models;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.Mvc;
namespace Hotelbookingsystem.Controllers
{

    public class BookingController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Booking booking)
        {
            string cs = ConfigurationManager.ConnectionStrings["HotelDB"].ConnectionString;

            SqlConnection con = new SqlConnection(cs);

            string query = "INSERT INTO Bookings(CustomerName,Email,CheckInDate,CheckOutDate) VALUES(@CustomerName,@Email,@CheckInDate,@CheckOutDate)";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@CustomerName", booking.CustomerName);
            cmd.Parameters.AddWithValue("@Email", booking.Email);
            cmd.Parameters.AddWithValue("@CheckInDate", booking.CheckInDate);
            cmd.Parameters.AddWithValue("@CheckOutDate", booking.CheckOutDate);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();


            ViewBag.Message = "Booking Successful!";

            return View();
        }
        public ActionResult List()
        {
            return Content("List Working");
        }
    }
}