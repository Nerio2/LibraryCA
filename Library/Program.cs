using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library {
	class Program {
		static void Main(string [] args) {
			Console.WriteLine("dziala");
			LibraryDataContext ldb = new LibraryDataContext();
			
			char c;
			string name="";
			do {
				Console.Clear();
				Console.WriteLine("Press \"`\" to Exit");
				Console.WriteLine("Looking for: " + name);
				Console.WriteLine("");
				var data = findAuthors(ldb , name , "");
				foreach ( var author in data ) {
					Console.WriteLine("====================");
					Console.WriteLine(author.name + " , " + author.authorId);
					Console.WriteLine("Books:");
					var bookData = BooksOfAuthor(ldb , author.authorId);
					foreach ( var book in bookData ) {
						Console.WriteLine(book.name);
					}
				}
				c = Console.ReadKey().KeyChar;
				name += c;
			} while ( c != '`' );

		}
		public static books [] BooksOfAuthor(LibraryDataContext ldb , int authorId) {
			var data = ldb.books.Where(b => b.authorId == authorId).ToArray();
			return data;
		}

		public static authors [] findAuthors(LibraryDataContext ldb , string firstName , string secondName) {
			authors [] aut = ldb.authors
				.Where(a => a.name.Contains(firstName))
				.Where(a => a.surname.Contains(secondName))
				.Take(10).ToArray();
			return aut;
		}
	}

}