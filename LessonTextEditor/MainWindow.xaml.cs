using LessonTextEditor.BL;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;

namespace LessonTextEditor
{


    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INumericUpDown, IMainWindow<string>
    {
        public MainWindow()
        {
            InitializeComponent();
            IMessageService messageService = new MessageService();
            IFileManager<string> manager = new FileManager();
            var presenter = new MainPresenter<string>(this, this, manager, messageService);
        }

        public string FilePath
        {
            get { return fldFilePath.Text; }
        }

        public string Content
        {
            get { return fldContent.Text; }
            set { fldContent.Text = value; }
        }

        public event EventHandler FileOpenClick;
        public event EventHandler FileSaveClick;
        public event EventHandler ContentChanged;

        private void btnSelect(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Текстовые файлы|*.txt|Все файлы|*.*";

            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                fldFilePath.Text = dlg.FileName;

                if (FileOpenClick != null) FileOpenClick(this, EventArgs.Empty);
            }
        }

        private void btnFileOpenClick(object sender, RoutedEventArgs e)
        {
            if (FileOpenClick != null) FileOpenClick(this, EventArgs.Empty);
        }

        private void btnSave(object sender, RoutedEventArgs e)
        {
            if (FileSaveClick != null) FileSaveClick(this, EventArgs.Empty);
        }

        private void fldContentChanged(object sender, TextChangedEventArgs e)
        {
            if (ContentChanged != null) ContentChanged(this, EventArgs.Empty);
        }

        public void SetSymbolsCount(int count)
        {
            txtCountSymbols.Text = count.ToString();
        }

        public void SetFontSize(int count)
        {
            fldContent.FontSize = count;
        }


        #region NumericUpDown
        public string TxtNum
        {
            get { return txtNum.Text; }
            set { txtNum.Text = value; }
        }

        public int NumValue
        {
            get { return int.Parse(txtNum.Text); }
            set { txtNum.Text = value.ToString(); }
        }

        public event EventHandler btnUpClick;
        public event EventHandler btnDownClick;
        public event EventHandler txtNumTextChanged;
        

        private void btnUp_Click(object sender, RoutedEventArgs e)
        {
            if (btnUpClick != null) btnUpClick(this, EventArgs.Empty);
        }

        private void btnDown_Click(object sender, RoutedEventArgs e)
        {
            if (btnDownClick != null) btnDownClick(this, EventArgs.Empty);
        }

        private void txtNum_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtNumTextChanged != null) txtNumTextChanged(this, EventArgs.Empty);
        }
        #endregion
    }
}
