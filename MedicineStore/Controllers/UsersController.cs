using MedicineStore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;

namespace MedicineStore.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class UsersController : ControllerBase
	{
		private readonly IConfiguration _configuration;

		public UsersController(IConfiguration configuration)
		{
			_configuration = configuration;
		}

		[HttpPost]
		[Route("resistration")]
		public Response Register(Users users)
		{
			Response response = new Response();

			DAL dal = new DAL();
			
			//SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("EMedCS").ToString());
			
			SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection").ToString());
			response = dal.Register(users, connection);
			return response;
		}

		[HttpPost]
		[Route("login")]
		public Response Login(Users users)
		{
			DAL dal = new DAL();
			SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection").ToString());
			Response response = dal.Login(users, connection);
			return response;
		}

		[HttpPost]
		[Route("viewUser")]
		public Response ViewUsers(Users users) 
		{
			DAL dal = new DAL();
			SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection").ToString());
			Response response = dal.ViewUser(users, connection);
			return response;
		
		}

		[HttpPost]
		[Route("updateProfile")]
		public Response UpdateProfile(Users users)
		{
			DAL dal = new DAL();
			SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection").ToString());
			Response response = dal.UpdateProfile(users, connection);
			return response;

		}
	}
}
