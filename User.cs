using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	public class User
	{
		private uint Id
		{
			get
			{

				return this.Id;
			}
			set
			{
				if (value == 0) {
					throw new Exception("nope");
				} else
				{
					this.Id = value;
				}
			}
		}
		private string AllowedNameSymbols = "абвеёжзийклмнопрстуфхцчшщьыъэюя";
		private string AllowedSymbolsPassword = "abcedfghijklmnopqrstuvwxyz";
		private string AllowedSymbolsPassword = "abcedfghijklmnopqrstuvwxyz";
		private string AllowedEmailSymbols = LatinSymbols;

		public string FirstName {
			get
			{
				return this.FirstName;
			}
			set
			{
				foreach (char c in value) {
					if (!AllowedNameSymbols.Contains(c.ToString())) {
						throw new Exception("Содержатся не русские символы");
					}
				}
				if (String.IsNullOrWhiteSpace(value) || String.IsNullOrEmpty(value)) {
					throw new Exception("null/пробелы/пусто");
				} else if (3 > value.Length) {
					throw new Exception("<3");
				} else if (value.Length > 12) {
					throw new Exception(">12");
				} else
				{
					this.FirstName = value;
				}
			}
		}
		public string LastName
		{
			get
			{
				return this.LastName;
			}
			set
			{
				foreach (char c in value) {
					if (!AllowedNameSymbols.Contains(c.ToString())) {
						throw new Exception("Содержатся не русские символы");
					}
				}
				if (String.IsNullOrWhiteSpace(value) || String.IsNullOrEmpty(value)) {
					throw new Exception("null/пробелы/пусто");
				} else if (3 > value.Length) {
					throw new Exception("<3");
				} else if (value.Length > 12) {
					throw new Exception(">12");
				} else
				{
					this.LastName = value;
				}
			}
		}
		public string Password
		{
			get
			{
				return "Password is hidden";
			}
			set
			{
				foreach (char c in value) {
					if (!AllowedSymbolsPassword.Contains(c.ToString())) {
						throw new Exception("Содержатся не английские символы или не разрешенные спец. символы");
					}
				}
				if (String.IsNullOrWhiteSpace(value) || String.IsNullOrEmpty(value)) {
					throw new Exception("null/пробелы/пусто");
				} else if (8 > value.Length) {
					throw new Exception("<8");
				} else if (value.Length > 19) {
					throw new Exception(">12");
				} else
				{
					this.Password = value;
				}
			}
		}
		public string Email
		{
			get
			{
				return this.Email;
			}
			set
			{
				foreach (char c in value.ToString()) {
					if (!AllowedSymbolsPassword.Contains(c)) {
						throw new Exception("Содержатся не английские символы или не разрешенные спец. символы");
					}
				}
				if (value is null || value.ToString().Contains(" ")) {
					throw new Exception("null");
				} else
				{
					this.Email = value;
				}
			}
		}
		public User(string firstName, string lastName, string password, string email) {
			this.FirstName = firstName;
			this.LastName = lastName;
			this.Password = password;
			this.Email = email;
		}
		public static uint GetId(User user) {
			return user.Id;
		}
		public override string ToString() {
			return $"{Id} | {FirstName} {LastName} {Email} | {Password}";
		}
	}
}