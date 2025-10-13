using ELTE.DocuStat.Model;

namespace DocuStatView
{
    public partial class DocuStatDialog : Form
    {
        private IDocumentStatistics? _documentStatistics;

        public DocuStatDialog()
        {
            InitializeComponent();
            openFileDialogMenuItem.Click += OpenDialog;
            countWordsMenuItem.Click += CountWords;
        }

        private void OpenDialog(object? sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.RestoreDirectory = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        _documentStatistics = new DocumentStatistics(openFileDialog.FileName);
                        _documentStatistics.FileContentReady += UpdateFileContent;
                        _documentStatistics.TextStatisticsReady += UpdateTextStatistics;
                        _documentStatistics.Load();
                    }
                    catch (System.IO.IOException ex)
                    {
                        MessageBox.Show("File reading is unsuccessful!\n" + ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
        }
        private void UpdateFileContent(object? sender, EventArgs e)
        {
            if (_documentStatistics?.FileContent == textBox.Text)
                return;
            textBox.Text = _documentStatistics?.FileContent;
            listBoxCounter.Items.Clear();
        }

        private void UpdateTextStatistics(object? sender, EventArgs e)
        {
            if (_documentStatistics == null)
                return;


            labelCharacters.Text = $"Character count: {_documentStatistics.CharacterCount}";
            labelNonWhitespaceCharacters.Text = $"Non-whitespace characters: {_documentStatistics.NonWhiteSpaceCharacterCount}";
            labelSentences.Text = $"Sentence count: {_documentStatistics.SentenceCount}";
            labelProperNouns.Text = $"Proper noun count: {_documentStatistics.ProperNounCount}";
            labelColemanLieuIndex.Text = $"Coleman Lieu Index: {_documentStatistics.ColemanLieuIndex:F2}";
            labelFleschReadingEase.Text = $"Flesch Reading Ease: {_documentStatistics.FleschReadingEase:F2}";
        }
        private void CountWords(object? sender, EventArgs e)
        {
            if (_documentStatistics == null || string.IsNullOrEmpty(_documentStatistics.FileContent))
            {
                MessageBox.Show("No file loaded yet!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int minLength = Convert.ToInt32(spinBoxMinLength.Value);
            int minOccurrence = Convert.ToInt32(spinBoxMinOccurrence.Value);

            List<string> ignoredWords = new List<string>();
            if (!string.IsNullOrEmpty(textBoxIgnoredWords.Text))
            {
                ignoredWords = textBoxIgnoredWords.Text
                    .Split(',', StringSplitOptions.RemoveEmptyEntries)
                    .Select(w => w.Trim())
                    .ToList();
            }

            var filteredWords = _documentStatistics.DistinctWordCount
                .Where(pair => pair.Key.Length >= minLength && pair.Value >= minOccurrence && !ignoredWords.Contains(pair.Key))
                .OrderByDescending(pair => pair.Value)
                .ThenBy(pair => pair.Key)
                .ToList();

            listBoxCounter.Items.Clear();
            listBoxCounter.BeginUpdate();
            foreach (var pair in filteredWords)
            {
                listBoxCounter.Items.Add($"{pair.Key}: {pair.Value}");
            }
            listBoxCounter.EndUpdate();
        }

    }
}
