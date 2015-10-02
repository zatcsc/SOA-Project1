using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace LibManDA
{
    public class Book
    {
        public static string API_URL = "https://soalibman.herokuapp.com";
        public static int attrCount = 7;
        public static String[] attrs = {"ID","Title","Author","Publisher","Category","Description","Cover"};
        public String id { get; set; }
        public String title { get; set; }
        public String author { get; set; }
        public String publisher { get; set; }
        public String description { get; set; }
        public String cover { get; set; }
        public String category { get; set; }
        public Book() { }        
        public Book(String id,String title,String author,String publisher,String description,String category)
        {
            this.id = id;
            this.title = title;
            this.author = author;
            this.publisher = publisher;
            this.description = description;
            this.category = category;
        }    
        public static List<Book> loadALlBook()
        {
            String url = API_URL + "/books";
            Console.WriteLine(url);
            WebClient wc = new WebClient();
            wc.Encoding = Encoding.UTF8;
            var json = wc.DownloadString(url);
            List<Book> books = (List<Book>)Newtonsoft.Json.JsonConvert.DeserializeObject<List<Book>>(json);
            return books;
        }
        public String[] toArray() {
            String[] arr = {this.id, this.title, this.author, this.publisher,this.category,this.description, this.cover};
            return arr;
        }
    }
}
