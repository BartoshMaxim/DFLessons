using System;
using LessonTextEditor.BL;

namespace LessonTextEditor
{
    class MainPresenter<T>
    {
        private readonly IMainWindow<T> _view;
        private readonly IFileManager<T> _manager;
        private readonly IMessageService _messageService;
        private readonly INumericUpDown _numericUpDown;

        private T _filePath;

        private readonly int _defaultNum = 11;
        private int _numValue;
        private readonly int _maxNum = 72;
        private readonly int _minNum = 6;

        public MainPresenter(IMainWindow<T> view, INumericUpDown numericUpDown, IFileManager<T> manager, IMessageService messageService)
        {
            _view = view;
            _manager = manager;
            _messageService = messageService;
            _numericUpDown = numericUpDown;

            _view.SetSymbolsCount(0);
            _view.ContentChanged += _view_ContentChanged;
            _view.FileOpenClick += _view_FileOpenClick;
            _view.FileSaveClick += _view_FileSaveClick;

            _numericUpDown.NumValue = _numValue = _defaultNum;
            _numericUpDown.btnUpClick += btnUp_Click;
            _numericUpDown.btnDownClick += btnDown_Click;
            _numericUpDown.txtNumTextChanged += txtNum_TextChanged;
        }

        private void _view_FileSaveClick(object sender, EventArgs e)
        {
            try
            {
                string content = _view.Content;

                _manager.SaveContent(content, _filePath);

                _messageService.ShowMessage("File success saved");
            }
            catch (Exception ex)
            {
                _messageService.ShowError(ex.Message);
            }
        }

        private void _view_FileOpenClick(object sender, EventArgs e)
        {
            try
            {
                 T  filePath = _view.FilePath;
                _filePath = filePath;

                bool isExist = _manager.IsExist(filePath);

                if (!isExist)
                {
                    _messageService.ShowExclamation("File not exists!");
                    return;
                }

                string content = _manager.GetContent(filePath);
                int count = _manager.GetSymbolCount(content);

                _view.Content = content;
                _view.SetSymbolsCount(count);
            }
            catch (Exception ex)
            {
                _messageService.ShowError(ex.Message);
            }
        }

        private void _view_ContentChanged(object sender, EventArgs e)
        {
            try
            {
                string content = _view.Content;

                int count = _manager.GetSymbolCount(content);

                _view.SetSymbolsCount(count);
            }
            catch (Exception ex)
            {
                _messageService.ShowError(ex.Message);
            }
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (_numericUpDown.NumValue < _maxNum)
                _numericUpDown.NumValue++;

        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            if (_numericUpDown.NumValue > _minNum)
                _numericUpDown.NumValue--;
        }

        private void txtNum_TextChanged(object sender, EventArgs e)
        {
            string txtNum = _numericUpDown.TxtNum;
            if (txtNum == null)
            {
                return;
            }

            if (!int.TryParse(txtNum, out _numValue))
                _numericUpDown.TxtNum = _defaultNum.ToString();
            else
            {
                if (_numValue < _maxNum + 1 && _numValue > _minNum - 1)
                {
                    _numericUpDown.TxtNum = _numValue.ToString();
                    _view.SetFontSize(_numValue);
                }
                else
                {
                    _numericUpDown.TxtNum = _defaultNum.ToString();
                    _view.SetFontSize(_defaultNum);
                }
            }
        }
    }
}
