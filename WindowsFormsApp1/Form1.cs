using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private readonly string templatePath = Path.Combine(Application.StartupPath, "Шаблон.docx");

        public Form1()
        {
            InitializeComponent();
        }

        private void ReplaceTextInDocument(Word.Document doc, string findText, string replaceWithText)
        {
            Word.Range range = doc.Content;
            range.Find.ClearFormatting();
            range.Find.Execute(FindText: findText, ReplaceWith: replaceWithText);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (FIO_TB.Text.Length > 0 && Product_TB.Text.Length > 0 && Sum_TB.Text.Length > 0 && Name_manager_TB.Text.Length > 0)
            {
                SaveFileDialog saveDialog = null;
                string outputPath = null;
                saveDialog = new SaveFileDialog();
                saveDialog.Title = "Сохранить документ как";
                saveDialog.Filter = "Документ Word (*.docx)|*.docx";
                saveDialog.DefaultExt = "docx";
                saveDialog.FileName = $"Документ_{FIO_TB.Text}.docx";
                saveDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                if (saveDialog.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
                outputPath = saveDialog.FileName;
                Word.Application wordApp = null;
                Word.Document wordDocument = null;
                try
                {
                    if (!File.Exists(templatePath))
                    {
                        MessageBox.Show("Файл шаблона не найден", "Ошибка");
                        return;
                    }
                    wordApp = new Word.Application();
                    wordApp.Visible = false;
                    wordApp.DisplayAlerts = Word.WdAlertLevel.wdAlertsNone;
                    wordDocument = wordApp.Documents.Open(templatePath, ReadOnly: true, AddToRecentFiles: false);
                    ReplaceTextInDocument(wordDocument, "{ФИО}", FIO_TB.Text);
                    ReplaceTextInDocument(wordDocument, "{Товар}", Product_TB.Text);
                    ReplaceTextInDocument(wordDocument, "{Сумма}", Sum_TB.Text);
                    ReplaceTextInDocument(wordDocument, "{ИмяМенеджера}", Name_manager_TB.Text);
                    wordDocument.SaveAs2(outputPath);
                    wordApp.DisplayAlerts = Word.WdAlertLevel.wdAlertsAll;
                    MessageBox.Show($"Документ успешно сохранён:\n{outputPath}", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (wordDocument != null)
                {
                    wordDocument.Close(false);
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(wordDocument);
                }
                if (wordApp != null)
                {
                    if (!wordApp.Visible)
                        wordApp.Quit();
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(wordApp);
                }
            }
            else
            {
                MessageBox.Show("Заполните поля");
            }
        }
        
    }
}

