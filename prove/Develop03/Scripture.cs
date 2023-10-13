using System.Text;

public class Scripture
{
    private Reference _reference;
    private List<Word> _scriptureWords = new List<Word>();


    public Scripture(Reference reference, string scriptureText)
    {
        _reference = reference;
        string[] separatedScriptureText = scriptureText.Split(" ");
        foreach (string word in separatedScriptureText)
        {
            Word newWord = new Word(word);
            _scriptureWords.Add(newWord);
        }
    }


    public void HideWords()
    {
        Random rng = new Random();
        int wordsLeftToHide = 3;
        while (wordsLeftToHide > 0 && IsCompletelyHidden() == false)
        {
            Word wordToHide = _scriptureWords[rng.Next(0, _scriptureWords.Count())];
            if (wordToHide.IsHidden() == false)
            {
                wordToHide.Hide();
                wordsLeftToHide --;
            }
        }
    }

    public string GetRenderedText()
    {
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.Append(_reference.GetRenderedText() + " ");
        foreach (Word word in _scriptureWords)
        {
            stringBuilder.Append(word.GetRenderedText() + " ");
        }
        return stringBuilder.ToString();
    }

    public bool IsCompletelyHidden()
    {
        bool isCompletelyHidden = true;
        foreach (Word word in _scriptureWords)
        {
            if (word.IsHidden() == false)
            {
                isCompletelyHidden = false;
                break;
            }
        }
        return isCompletelyHidden;
    }
}