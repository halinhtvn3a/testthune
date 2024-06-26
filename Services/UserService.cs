﻿using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Services
{
	public class UserService
	{
		private readonly UserRepository UserRepository = null;
		public UserService()
		{
			if (UserRepository == null)
			{
				UserRepository = new UserRepository();
			}
		}
		public IdentityUser AddUser(IdentityUser User) => UserRepository.AddUser(User);
		//public void DeleteUser(string id) => UserRepository.DeleteUser(id);
		public IdentityUser GetUser(string id) => UserRepository.GetUser(id);
		public List<IdentityUser> GetUsers() => UserRepository.GetUsers();
		//public IdentityUser UpdateUser(string id, IdentityUser User) => UserRepository.UpdateUser(id, User);
		public IdentityUser BanUser(string id, IdentityUser user) => UserRepository.BanUser(id,user);
		public IdentityUser UnbanUser(string id, IdentityUser user) => UserRepository.UnbanUser(id, user);
	}
}
