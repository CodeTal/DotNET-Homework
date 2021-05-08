using System;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net;
using System.Collections;
using System.IO;
using System.Threading.Tasks;

namespace Homework9
{
    public partial class Form1 : Form
    {
        public Hashtable urls = new Hashtable();
        public int count = 0;
        public string postfix;
        public string root_dom;
        
        public void Crawl() {
            while (true) {
                string current = null;
                foreach (string url in urls.Keys) {
                    if ((bool)urls[url]) continue;
                    current = url;
                }

                if (current == null || count > 5) break;
                string html = DownLoad(current); // 下载
                urls[current] = true;
                count++;
                crawledTextBox.Text += current + "\n";
                Parse(html);//解析,并加入新的链接
            }
        }
        
        public string DownLoad(string url) {
            try {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                string html = webClient.DownloadString(url);
                string fileName = count.ToString() + ".html";
                File.WriteAllText(fileName, html, Encoding.UTF8);
                return html;
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
                return "";
            }
        }
        
        private void Parse(string html) {
            string strRef = @"(href|HREF)[]*=[]*[""'][^""'#>]+[""']";
            MatchCollection matches = new Regex(strRef).Matches(html);
            foreach (Match match in matches) {
                strRef = match.Value.Substring(match.Value.IndexOf('=') + 1)
                    .Trim('"', '\"', '#', '>');
                if (strRef.Length == 0) continue;
                if (!Regex.IsMatch(strRef, "(html|htm|aspx|jsp)$"))
                {
                    failedTextBox.Text += strRef + "\n";
                    continue;
                }
                
                if (!Regex.IsMatch(strRef, root_dom))
                {
                    failedTextBox.Text += strRef + "\n";
                    continue;
                }

                if (!Regex.IsMatch(strRef, "^(https|http)"))
                {
                    int index = 0;
                    while (strRef[index] == '.')
                    {
                        index++;
                    }

                    strRef = postfix + strRef.Substring(index, strRef.Length - index);
                }
                if (urls[strRef] == null) urls[strRef] = false;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            crawledTextBox.Text = "";
            failedTextBox.Text = "";
            urls = new Hashtable();
            count = 0;
            string url = urlTextBox.Text;
            postfix = url;
            string[] doms = url.Split('.');
            root_dom = doms[doms.Length - 2];
            urlTextBox.Text = "";
            urls.Add(url,false); 
            Task.Run(Crawl);
        }
    }
}