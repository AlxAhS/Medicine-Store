using MedicineStore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;

namespace MedicineStore.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class MedicinesController : ControllerBase
	{
		private readonly IConfiguration _configuration;

		public MedicinesController(IConfiguration configuration)
		{
			_configuration = configuration;
		}

		[HttpPost]
		[Route("addToCart")]
		public Response AddToCart(Cart cart)
		{
			DAL dal = new DAL();
			SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection").ToString());
			Response response = dal.AddToCart(cart, connection);
			return response;
		}

		[HttpPost]
		[Route("placeOrder")]
		public Response PlaceOrder(Users users)
		{
			DAL dal = new DAL();
			SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection").ToString());
			Response response = dal.PlaceOrder(users, connection);
				return response;
		}

		[HttpPost]
		[Route("orderList")]
		public Response OrderList(Users users)
		{
			DAL dal = new DAL();
			SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection").ToString());
			Response response = dal.OrderList(users, connection);
			return response;

		}
	}
}
