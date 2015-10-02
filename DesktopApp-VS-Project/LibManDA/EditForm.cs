using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Collections.Specialized;
using System.IO;
using System.Net.Cache;
using Newtonsoft.Json.Linq;

namespace LibManDA
{
    public class UploadResult
    {
        public string img_url;
    }
    public partial class EditForm : Form
    {        
        public EditForm()
        {
            InitializeComponent();            
        }
        public void setData(Book book)
        {
            this.idBox.Text = book.id;
            this.titleBox.Text = book.title;
            this.authorBox.Text = book.author;
            this.publisherBox.Text = book.publisher;
            this.descBox.Text = book.description;
            this.urlTextBox.Text = book.cover;
            string defaultCate = "Textbook";
            if (book.category != null) defaultCate = book.category;
            this.cateComboBox.SelectedIndex = cateComboBox.FindStringExact(defaultCate);
            Console.WriteLine(book.cover);
            if (book.cover != null) {
                this.coverPB.Load(book.cover);
            }
                
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            WebClient wc = new WebClient();
            wc.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
            NameValueCollection data = new NameValueCollection();
            data.Add("id", this.idBox.Text);
            data.Add("title", this.titleBox.Text);
            data.Add("author", this.authorBox.Text);
            data.Add("publisher", this.publisherBox.Text);
            data.Add("description", this.descBox.Text);          
            data.Add("category", this.cateComboBox.Text);
            wc.Encoding = Encoding.UTF8;                        
            if (coverImage != null) {
                String result = uploadIM("cover.jpg");                
                String res = ((JObject)JObject.Parse(result)["data"])["img_url"].ToString();
                res = convertImageURL(res);
                Console.WriteLine(res);
                if (res != null) this.urlTextBox.Text = res;
            }                        
            data.Add("cover", this.urlTextBox.Text);
            wc.UploadValues("https://soalibman.herokuapp.com/book/add", data);
            Program.container.loadBookAndView();            
        }
        private String convertImageURL(String url)
        {
            int index = url.LastIndexOf("/");
            url = url.Insert(index, "/d");
            return url;        
        }
        private String uploadIM(String img)
        {            
            String url = "http://uploads.im/api";
            string boundary = "----------------------------" + DateTime.Now.Ticks.ToString("x");
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            req.Method = "POST";
            req.ContentType = "multipart/form-data; boundary=" + boundary;
            req.KeepAlive = true;
            req.Credentials = System.Net.CredentialCache.DefaultCredentials;
            string filePath = "cover.jpg";
            Stream memStream = new MemoryStream();
            byte[] boundarybytes = System.Text.Encoding.ASCII.GetBytes("\r\n--" + boundary + "\r\n");
            string formdataTemplate = "\r\n--" + boundary + "\r\nContent-Disposition:  form-data; name=\"{0}\";\r\n\r\n{1}";
            string headerTemplate = "Content-Disposition: form-data; name=\"{0}\"; filename=\"{1}\"\r\n Content-Type: application/octet-stream\r\n\r\n";
            memStream.Write(boundarybytes, 0, boundarybytes.Length);
            string header = string.Format(headerTemplate, "upload", filePath);
            byte[] headerbytes = System.Text.Encoding.UTF8.GetBytes(header);
            memStream.Write(headerbytes, 0, headerbytes.Length);
            FileStream fileStream = new FileStream(filePath, FileMode.Open,
                   FileAccess.Read);
            byte[] buffer = new byte[1024];
            int bytesRead = 0;
            while ((bytesRead = fileStream.Read(buffer, 0, buffer.Length)) != 0)
            {
                memStream.Write(buffer, 0, bytesRead);
            }
            memStream.Write(boundarybytes, 0, boundarybytes.Length);
            fileStream.Close();
            req.ContentLength = memStream.Length;
            Stream requestStream = req.GetRequestStream();
            memStream.Position = 0;
            byte[] tempBuffer = new byte[memStream.Length];
            memStream.Read(tempBuffer, 0, tempBuffer.Length);
            memStream.Close();
            requestStream.Write(tempBuffer, 0, tempBuffer.Length);
            requestStream.Close();
            try
            {
                WebResponse webResponse = req.GetResponse();
                Stream stream = webResponse.GetResponseStream();
                StreamReader reader = new StreamReader(stream);
                string var = reader.ReadToEnd();                
                return var;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return null;            
        }
        private String uploadImage(String img)
        {
            String url = "http://www.deviantsart.com";
            string boundary = "----------------------------" + DateTime.Now.Ticks.ToString("x");
            HttpWebRequest req = (HttpWebRequest) WebRequest.Create(url);            
            req.Method = "POST";
            req.ContentType = "multipart/form-data; boundary=" + boundary;
            req.KeepAlive = true;
            req.Credentials = System.Net.CredentialCache.DefaultCredentials;
            string filePath = "cover.jpg";
            Stream memStream = new MemoryStream();
            byte[] boundarybytes = System.Text.Encoding.ASCII.GetBytes("\r\n--" + boundary + "\r\n");
            string formdataTemplate = "\r\n--" + boundary + "\r\nContent-Disposition:  form-data; name=\"{0}\";\r\n\r\n{1}";
            string headerTemplate = "Content-Disposition: form-data; name=\"{0}\"; filename=\"{1}\"\r\n Content-Type: application/octet-stream\r\n\r\n";
            memStream.Write(boundarybytes, 0, boundarybytes.Length);
            string header = string.Format(headerTemplate, "uploadFile",filePath);
            byte[] headerbytes = System.Text.Encoding.UTF8.GetBytes(header);
            memStream.Write(headerbytes, 0, headerbytes.Length);
            FileStream fileStream = new FileStream(filePath, FileMode.Open,
                   FileAccess.Read);
            byte[] buffer = new byte[1024];
            int bytesRead = 0;
            while ((bytesRead = fileStream.Read(buffer, 0, buffer.Length)) != 0)
            {
                memStream.Write(buffer, 0, bytesRead);
            }
            memStream.Write(boundarybytes, 0, boundarybytes.Length);
            fileStream.Close();
            req.ContentLength = memStream.Length;
            Stream requestStream = req.GetRequestStream();
            memStream.Position = 0;
            byte[] tempBuffer = new byte[memStream.Length];
            memStream.Read(tempBuffer, 0, tempBuffer.Length);
            memStream.Close();
            requestStream.Write(tempBuffer, 0, tempBuffer.Length);
            requestStream.Close();
            try
            {
                WebResponse webResponse = req.GetResponse();
                Stream stream = webResponse.GetResponseStream();
                StreamReader reader = new StreamReader(stream);
                string var = reader.ReadToEnd();
                return var;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return null;
        }


        
        private void EditForm_Load(object sender, EventArgs e)
        {

        }

        private void selectBtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                String path = openFileDialog.FileName;
                Image originalIMG = Image.FromFile(path);
                coverImage = ScaleImage(originalIMG, coverPB.Width, coverPB.Height);
                coverImage.Save("cover.jpg",System.Drawing.Imaging.ImageFormat.Jpeg);
                coverPB.Image = coverImage;
            }
        }
        public static Image ScaleImage(Image image, int maxWidth, int maxHeight)
        {
            var ratioX = (double)maxWidth / image.Width;
            var ratioY = (double)maxHeight / image.Height;
            var ratio = Math.Min(ratioX, ratioY);

            var newWidth = (int)(image.Width * ratio);
            var newHeight = (int)(image.Height * ratio);

            var newImage = new Bitmap(newWidth, newHeight);

            using (var graphics = Graphics.FromImage(newImage))
                graphics.DrawImage(image, 0, 0, newWidth, newHeight);

            return newImage;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
