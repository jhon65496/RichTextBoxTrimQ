using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace RichTextBoxTrimQ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TestData testData = new TestData();
            richTextBox1.Rtf = testData.GetDataTest1();
        }

        private void button1_Click(object sender, EventArgs e)
        {
			var lines = richTextBox1.Lines;

			for (int i = 0; i < richTextBox1.Lines.Count(); i++)
			{
				var start = richTextBox1.GetFirstCharIndexFromLine(i);  // Индекс начального символа Line                
				var length = lines[i].Length;                  // Длинна Line

				// richTextBox1.Select(start, length);                     // Выбираем диапазон символов Line
				Debug.WriteLine($" ");
				Debug.WriteLine($"Line :{i} -- start:{start} -- length:{length} --- ---- --- --- --- --- --- ---");
				richTextBox1.Select(start, length);                     // Выбираем диапазон символов Line
				string lineOrig = richTextBox1.SelectedText;
				Debug.WriteLine($"lineOrig -- {lineOrig}");


				richTextBox1.SelectionStart = start;
				// Поиск пустых символов в Line
				//for (int i2 = start; i2 < start + length; i2++)
				for (int i2 = 1; i2 < length; i2++)
				{
					richTextBox1.SelectionLength = i2;
					string selectSymbolLine = richTextBox1.SelectedText;
					Debug.WriteLine($" i2:{i2}");
					Debug.WriteLine($"selectSymbolLine:--- {selectSymbolLine}");

					// Для тестирования
					if (i == 6 && i2 == 1)
					{
						var sdf = selectSymbolLine;
					}

					// bool dfd = !(i2 == 0);
					// if ((result == null) & !(i2 == 0))
					if ((selectSymbolLine == "")
						|| (selectSymbolLine == " ")
						|| (selectSymbolLine == null))
					{
						// richTextBox1.SelectionLength = i2 - 1;
						richTextBox1.SelectionLength = i2;
						richTextBox1.SelectedText = String.Empty;
						Debug.WriteLine("Deleted - Space ok! ok! ok! ok! ok! ok! ok! ok!");
						// break;
						continue;
					}

					// if (!String.IsNullOrEmpty(result))                    
					if (!(selectSymbolLine == ""))
					// if (!(selectSymbolLine == "") || (selectSymbolLine == null))
					// if (!(selectSymbolLine == "") || !(selectSymbolLine == null))
					// if (!(selectSymbolLine == null))
					// if (!(selectSymbolLine == ""))
					{
						Debug.WriteLine($"XXX Break XXX XXX XXX XXX XXX XXX XXX XXX XXX XXX");
						break;
					}
				}

				// Output --- --- --
				var startResult = richTextBox1.GetFirstCharIndexFromLine(i);  // Индекс начального символа Line                
				var lengthResult = lines[i].Length;                  // Длинна Line
				richTextBox1.Select(startResult, lengthResult);                     // Выбираем диапазон символов Line
				string lineResult = richTextBox1.SelectedText;
				Debug.WriteLine($"lineResult -- {lineResult}");
			}
			Debug.WriteLine($"button1_Click End");
		}
    }
}
