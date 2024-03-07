using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	public class User
	{
		private uint _Id;
		private uint Id
		{
			get
			{
				return _Id;
			}
			set
			{
				if (value == 0) {
					throw new Exception("nope");
				} else
				{
					this._Id = value;
				}
			}
		}
		private string CyrillicSymbols = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
		private string LatinSymbols = "";
		for (int i = 97; i <= 122; i++) {
			LatinSymbols += (char)i;
		}
		private string SpecialSymbols = "";
		for (int i = 33; i <= 46; i++) {
			SpecialSymbols += (char)i;
		}
		private string AllowedPasswordSymbols = LatinSymbols + SpecialSymbols;
		private string AllowedEmailSymbols = LatinSymbols + "@.";
		private string _FirstName;
		public string FirstName {
			get
			{
				return _FirstName;
			}
			set
			{
				foreach (char c in value) {
					if (!CyrillicSymbols.Contains(c.ToString())) {
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
					this._FirstName = value;
				}
			}
		}
		private string _LastName;
		public string LastName
		{
			get
			{
				return this._LastName;
			}
			set
			{
				foreach (char c in value) {
					if (!CyrillicSymbols.Contains(c.ToString())) {
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
					this._LastName = value;
				}
			}
		}
		private string _Password;
		public string Password
		{
			get
			{
				return "Password is hidden";
			}
			set
			{
				bool hasSpecialSymbol = true;
				foreach (char c in value) {
					if (!AllowedPasswordSymbols.Contains(c.ToString())) {
						throw new Exception($"Содержатся не английские символы или не разрешенные спец. символы Символ: {c}");
					}
					if (SpecialSymbols.Contains(c)) {
						hasSpecialSymbol = true;
					}
				}
				if (!hasSpecialSymbol) {
					throw new Exception("Отсутствует спец. символ");
				}
				if (String.IsNullOrWhiteSpace(value) || String.IsNullOrEmpty(value)) {
					throw new Exception("null/пробелы/пусто");
				} else if (8 > value.Length) {
					throw new Exception("<8");
				} else if (value.Length > 19) {
					throw new Exception(">12");
				} else
				{
					this._Password = value;
				}
			}
		}
		private string _Email;
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				uint sobakaCount = 0;
				uint dotsCount = 0;
				foreach (char c in value.ToString()) {
					if (!AllowedEmailSymbols.Contains(c)) {
						throw new Exception("Содержатся не английские символы или не разрешенные спец. символы");
					}
					if (c == '@') {
						sobakaCount++;
					}
					if (c == '.') {
						dotsCount++;
					}
				}
				if (sobakaCount != 1) {
					throw new Exception("Собака");
				}
				if (dotsCount == 0) {
					throw new Exception("Точки");
				}
				if (value.IsNullOrEmpty || value.IsNullOrWhiteSpace {
					throw new Exception("null/пробелы/пусто");
				} else
					{
						this._Email = value;
					}
				}
			}
			public User(string firstName, string lastName, string password, string email) {
				this.FirstName = firstName;
				this.LastName = lastName;
				this.Password = password;
				this.Email = email;
			}
			public uint GetId(User user) {
				return this.user.Id;
			}
			public override string ToString() {
				return $"{Id} | {FirstName} {LastName} {Email} | {Password}";
			}
		}
	}