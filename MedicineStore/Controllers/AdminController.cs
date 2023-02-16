using MedicineStore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace MedicineStore.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AdminController : ControllerBase
	{
		private readonly IConfiguration _configuration;

		public AdminController(IConfiguration configuration)
		{
			_configuration = configuration;
		}

		[HttpPost]
		[Route("addUpdateMedicine")]
		public Response AddUpdateMedicine(Medicines medicines)
		{
			DAL dal = new DAL();
			SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection").ToString());
			Response response = dal.AddUpdateMedicine(medicines, connection);
			return response;
		}

		[HttpGet]
		[Route("userList")]
		public Response UserList()
		{
			DAL dal = new DAL();
			SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection").ToString());
			Response response = dal.UserList(connection);
			return response;
		}
	}
}
