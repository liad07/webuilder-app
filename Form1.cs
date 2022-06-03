using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;



namespace webuilder
{
    public partial class webuilder : Form
    {
        public webuilder()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] lines = System.IO.File.ReadAllLines(@"license.txt");

            String x =textBox1.Text;
            for(int i = 0; i < lines.Length; i++)
            {
                if (x == lines[i])
                {
                    label1.Text = "log confirmed";
                    label1.Visible = false;
                    textBox1.Visible = false;
                    button1.Visible = false;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                    label6.Visible = true;
                    label7.Visible = true;
                    label8.Visible = true;
                    label9.Visible = true;
                    label10.Visible = true;
                    label11.Visible = true;
                    label12.Visible = true;
                    label13.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    textBox5.Visible = true;
                    textBox6.Visible = true;
                    textBox7.Visible = true;
                    textBox8.Visible = true;
                    textBox9.Visible = true;
                    textBox10.Visible = true;
                    textBox11.Visible = true;
                    textBox12.Visible = true;
                    button2.Visible = true;
                    label15.Visible = false;
                    label16.Visible = false;
                    break;
                }
                else
                {
                    label1.Text = "log not confirmed";
                }
              
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = textBox3.Text;
            string topnavcolor = textBox9.Text;
            string background = textBox7.Text;
            string topnavhover = textBox10.Text;
            string topnavactiv = textBox8.Text;
            string text1 = textBox11.Text;
            string text2 = textBox12.Text;
            string img1 = textBox6.Text;
            string img2 = textBox4.Text;
            string img3 = textBox5.Text;
            string logo = textBox2.Text;

            string css = ".topnav { overflow: hidden; background-color:" + topnavcolor + "; } .topnav a { float: left; color: #000000; text-align: center; padding: 14px 16px; text-decoration: none; font-size: 17px; } .topnav a:hover { background-color: " + topnavhover + "; color: #000000; } .topnav a.active { background-color:" + topnavactiv + "; color: white; } .topnav-right { float: right; weight: 10% !important; height: 5% !important; } .center { text-align: center; } .login{ height: 30%; text-align: right ; background-color: " + topnavcolor + "; float: right; } body { background-color: " + background + ";} * {box-sizing: border-box} body {font-family: Verdana, sans-serif; margin:0} .mySlides {display: none} img {vertical-align: middle;} /* Slideshow container */ .slideshow-container { max-width: 1000px; position: relative; margin: auto; } /* Next & previous buttons */ .prev, .next { cursor: pointer; position: absolute; top: 50%; width: auto; padding: 16px; margin-top: 300px; color: #111111; font-weight: bold; font-size: 18px; transition: 0.6s ease; border-radius: 0 3px 3px 0; user-select: none; } /* Position the  to the right */ .next { right: 0; border-radius: 3px 0 0 3px; } /* On hover, add a black background color with a little bit see-through */ .prev:hover, .next:hover { background-color: rgb(26, 227, 173); } /* Caption text */ .text { color: #ffffff; font-size: 15px; padding: 8px 12px; position: absolute; bottom: 8px; width: 100%; text-align: center; } /* Number text (1/3 etc) */ .numbertext { color: #f2f2f2; font-size: 12px; padding: 8px 12px; position: absolute; top: 0; } /* The dots/bullets/indicators */ .dot { cursor: pointer; height: 15px; width: 15px; margin: 0 2px; background-color: #bbb; border-radius: 50%; display: inline-block; transition: background-color 0.6s ease; } .active, .dot:hover { background-color: #717171; } /* Fading animation */ .fade { -webkit-animation-name: fade; -webkit-animation-duration: 1.5s; animation-name: fade; animation-duration: 1.5s; } @-webkit-keyframes fade { from {opacity: .4} to {opacity: 1} } @keyframes fade { from {opacity: .4} to {opacity: 1} } /* On smaller screens, decrease text size */ @media only screen and (max-width: 300px) { .prev, .next,.text {font-size: 11px} } .galimg{ width: 1000px; height: 700px; } .login{ margin-top: 110px; margin-right:-200px ; }";
            string home = "<!DOCTYPE html>\n <html>\n <head>\n <link rel='stylesheet' href='https://cdn.jsdelivr.net/npm/bootstrap@4.5.3/dist/css/bootstrap.min.css'>\n <meta charset='UTF-8'> \n<title>" + name + "</title> \n<link rel='stylesheet' href='Styles.css'>\n <link rel='icon' href='images/logo.png'> \n</head>\n <body> \n<div class='background'>\n <div class='center'>\n <div class='topnav'>\n <a class='active' href='Home.html'>Home</a>\n <a href='Registration.html'>Registration</a>\n <a href='CreateContentItem.html'>CreateContentItem</a>\n <a href='SharedContent.html'>SharedContent</a>\n <a href='gallery.html'>gallery</a>\n <a href='About.html'>About</a> \n</div> \n<img class='topnav-right' id='img' src='images/logo.png' width='200px' height='200px' onclick='rotateImg()'>\n </div> \n<div class='center'> \n<h1>" + text1 + "</h1> \n<h2>" + text2 + "</h2> \n<table class='login'> \n<tr> \n<td> \n<h3 class='center'>login form</h3> \n</td>\n </tr> \n<tr> \n<td> \n<input type='text' placeholder='user'> \n</td> \n</tr> \n<tr> \n<td>\n <input type='password' placeholder='password'> \n</td> \n</tr>\n <tr>\n <td>\n <input type='submit' value='login'>\n </td>\n </tr>\n <tr> \n<td> \n<a href='Registration.html'>link 2 Registration</a> \n</td>\n </tr>\n </table> \n<div class='center'> <img src='images/img1.png' height='250' width='300'> \n<img src='images/img2.png' height='250' width='300'> \n<img src='images/img3.png' height='250' width='300'>\n <script src='main.js'></script>\n </div> \n</div> \n</div> \n</body> \n</html>";
            string registration = "<!DOCTYPE html> \n<html>\n <head>\n <link rel='stylesheet' href='https://cdn.jsdelivr.net/npm/bootstrap@4.5.3/dist/css/bootstrap.min.css'> \n<meta charset='UTF-8'> \n<title>" + name + "|Registration</title> \n<link rel='stylesheet' href='Styles.css'> \n<link rel='icon' href='images/logo.png'> \n</head>\n <body>\n <div class='center'>\n <div class='topnav'>\n <a href='Home.html'>Home</a> \n<a class='active' href='Registration.html'>Registration</a>\n <a href='CreateContentItem.html'>CreateContentItem</a> \n<a href='SharedContent.html'>SharedContent</a>\n <a href='gallery.html'>gallery</a> \n<a href='About.html'>About</a>\n </div> \n<h1>Registration Page</h1>\n <form> \n<input type='text' name='fname' size='8'>\n <b>first name</b>\n <br> </br>\n <input type='text' name='user' size='8'>\n<b>username</b>\n<br></br> \n<input type='email' id='email' placeholder='example@gmail.com'>\n<b>email</b>\n<br></br> \n<input type='password' id='password'>\n<b>password</b>\n<br></br> \n<input type='datetime-local' id='date'>\n<b>born date</b>\n<br></br>\n <b>gender</b>\n<br> \n<input type='radio' name='gender' value='male'>male<br> \n<input type='radio' name='gender' value='female'>female<br>\n <br>\n</br> <b>area</b> <br></br> <select name='area'> \n<option value='north'> north \n<option value='west'> west \n<option value='center'> \ncenter <option value='outofIL'>out of ISRAEL \n</select>\n <br>\n </br>\n<div class='center'> \n<input type='submit' onclick='is_valid()'> \n<input type='reset'>\n </div>\n </form> \n</div> \n<script src='main.js'></script> \n</body>\n </html>";
            string CreateContentItem = "<!DOCTYPE html> \n<html> \n<head>\n<link rel='stylesheet' href='https://cdn.jsdelivr.net/npm/bootstrap@4.5.3/dist/css/bootstrap.min.css'> \n<meta charset='UTF-8'> \n<title>"+name+ "|CreateContentItem</title>\n <link rel='stylesheet' href='Styles.css'>\n <link rel='icon' href='images/logo.png'> \n</head>\n <body> \n<div class='center'> \n<div class='topnav'> \n<a href='Home.html'>Home</a> \n<a href='Registration.html'>Registration</a> \n<a class='active' href='CreateContentItem.html'>CreateContentItem</a>\n <a href='SharedContent.html'>SharedContent</a>\n <a href='gallery.html'>gallery</a> \n<a href='About.html'>About</a> \n</div> \n<div class='center'> \n<form>\n <h1><u>Content creation page</u></h1>\n<br><br> \n<b>type of </b><br>\n<input type='text'>\n<br><br><br> \n<input type='radio' name='yad'><b> 1 </b><br>\n <input type='radio' name='yad'><b>2</b>\n<br>\n <input type='radio' name='yad'><b> 3 </b>\n<br> <br>\n<b>date</b> <br><input type='datetime-local'> \n<br><br> \n<b>price</b> \n<br> \n<input type='number'> <br>\n <b>photo of</b> <br> \n<input type='file' accept='.png,.jpg,.jpeg'> \n<br><br><br> \n<input type='submit'><input type='reset'> \n</form>\n </div> \n</div> \n<script src='main.js'></script>\n </body>\n" + " </html>";
            string SharedContent = "<!DOCTYPE html> \n<html> \n<head>\n <link rel='stylesheet' href='https://cdn.jsdelivr.net/npm/bootstrap@4.5.3/dist/css/bootstrap.min.css'> \n<meta charset='UTF-8'> \n<title>"+name+ "|SharedContent</title> \n<link rel='stylesheet' href='Styles.css'> \n<link rel='icon' href='images/logo.png'>\n </head>\n <body> \n<div class='center'>\n <div class='topnav'>\n <a href='Home.html'>Home</a>\n <a href='Registration.html'>Registration</a> \n<a href='CreateContentItem.html'>CreateContentItem</a>\n <a class='active' href='SharedContent.html'>SharedContent</a> \n<a href='gallery.html'>gallery</a>\n <a href='About.html'>About</a>\n </div> \n<h1 class='center'>SharedContent page</h1> \n<table border=2 text align='center'> \n<tr text align='center'> \n<th>photo of</th>\n <th>name of</th> \n<th>date</th> \n<th>price</th>\n </tr>\n <tr text align='center'> \n<td><img src='images/img1.png' height='200' width='300'></td>\n <th><h1>first name</h1></th>\n <th><h1>first date</h1></th>\n <th><h1>first price</h1></th> </tr> <tr text align='center'> \n<td><img src='images/img2.png' height='200' width='300'></td>\n <th><h1>second name</h1></th> \n<th><h1>second date</h1></th> \n<th><h1>second price</h1></th> \n</tr> \n<tr text align='center'> \n<td><img src='images/img3.png' height='200' width='300'></td> \n<th><h1>third name</h1></th> \n<th><h1>third date</h1></th> \n<th><h1>third price</h1></th> \n</tr>\n </table> \n<script src='main.js'></script> \n</body>\n </html>";
            string gallery = "<!DOCTYPE html> \n<html>\n <head> \n<meta charset='UTF-8'> \n<title>" + name+"|gallery</title> \n<link rel='stylesheet' href='Styles.css'>\n <link rel='icon' href='images/logo.png'>\n </head>\n <body  onload='currentSlide(1)' >\n <div class='center'> \n<div class='topnav'>\n <a href='Home.html'>Home</a> \n<a href='Registration.html'>Registration</a>\n <a href='CreateContentItem.html'>CreateContentItem</a>\n <a href='SharedContent.html'>SharedContent</a> \n<a class='active' href='gallery.html'>gallery</a> \n<a href='About.html'>About</a> </div>\n <h1 class='center'>our images</h1> \n<div class='slideshow-container'> \n<div class='mySlides fade'> \n<div class='numbertext'>1 / 3</div> <img class='galimg' src='images/img1.png' style='width:100%'> </div> \n<div class='mySlides fade'> <div class='numbertext'>2 / 3</div> <img class='galimg' src='images/img2.png' style='width:100%'> \n</div>\n <div class='mySlides fade'> \n<div class='numbertext'>3 / 3</div> \n<img class='galimg' src='images/img3.png' style='width:100%'> \n</div> \n<a class='prev' onclick='plusSlides(-1)'>&#10094;</a> \n<a class='next' onclick='plusSlides(1)'>&#10095;</a> </div>\n <br>\n <div style='text-align:center'> \n<span class='dot' onclick='currentSlide(1)'></span>\n <span class='dot' onclick='currentSlide(2)'></span>\n<span class='dot' onclick='currentSlide(3)'></span>\n </div>\n <script src='main.js'></script> \n</body>\n </html>";
            string about = "<!DOCTYPE html> \n<html> \n<head> \n<meta charset='UTF-8'>\n <title>" + name+"|about</title> \n<link rel='stylesheet' href='Styles.css'>\n <link rel='icon' href='images/logo.png'> \n</head> \n<body>\n <div class='center'> \n<div class='topnav'> \n<a href='Home.html'>Home</a>\n <a href='Registration.html'>Registration</a> <a href='CreateContentItem.html'>CreateContentItem</a>\n <a href='SharedContent.html'>SharedContent</a>\n <a href='gallery.html'>gallery</a> \n<a class='active' href='About.html'>About</a> \n</div> \n<div class='center'> \n<h1>" + text1+ "</h1> \n<h2>" + text2+ "</h2> \n</div> \n<script src='main.js'></script>\n </body> \n</html>";
            System.IO.Directory.CreateDirectory(name);
            System.IO.Directory.CreateDirectory(name+"/"+"images");
            using (WebClient client = new WebClient())
            {
                client.DownloadFile(img1,
                @"" + name + "/" + "images" + "/" + "img1.png");
                client.DownloadFile(img2,
                 @"" + name + "/" + "images" + "/" + "img2.png");
                client.DownloadFile(img3,
                 @"" + name + "/" + "images" + "/" + "img3.png");
                client.DownloadFile(logo,
                @"" + name + "/" + "images" + "/" + "logo.png");
                client.DownloadFile("https://raw.githubusercontent.com/liad07/barca-v3/main/Main.js",
                @"" + name + "/"  + "main.js");
            }


            File.WriteAllText(@"" + name + "/" + "Styles.css", css);
            File.WriteAllText(@""+name+"/"+"Home.html", home);
            File.WriteAllText(@""+name+"/"+ "Registration.html", registration);
            File.WriteAllText(@"" + name + "/" + "CreateContentItem.html", CreateContentItem);
            File.WriteAllText(@"" + name + "/" + "SharedContent.html", SharedContent);
            File.WriteAllText(@"" + name + "/" + "gallery.html", gallery);
            File.WriteAllText(@"" + name + "/" + "about.html", about);


        }
    }
}
