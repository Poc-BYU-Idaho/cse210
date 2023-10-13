using System.Text;

public class Word
{
    private string _wordString;
    private bool _hidden = false;


    public Word(string wordString)
    {
        _wordString = wordString;
    }


    public void Hide()
    {
        _hidden = true;
    }

    public void Show()
    {
        _hidden = false;
    }

    public bool IsHidden()
    {
        return _hidden;
    }

    public string GetRenderedText()
    {
        if (_hidden == false)
        {
            return _wordString;
        }
        else if (_wordString.Contains(",") || _wordString.Contains(".") || _wordString.Contains(";") || _wordString.Contains("'") || _wordString.Contains("\"") || _wordString.Contains("!") || _wordString.Contains("?"))
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < _wordString.Length - 1; i ++)
            {
                stringBuilder.Append("_");
            }
                if (_wordString.Contains(","))
                {
                    stringBuilder.Append(",");
                }
                else if (_wordString.Contains("."))
                {
                    stringBuilder.Append(".");
                }
                else if (_wordString.Contains(";"))
                {
                    stringBuilder.Append(";");
                }
                else if (_wordString.Contains("'"))
                {
                    stringBuilder.Append("'");
                }
                else if (_wordString.Contains("\""))
                {
                    stringBuilder.Append("\"");
                }
                else if (_wordString.Contains("!"))
                {
                    stringBuilder.Append("!");
                }
                else if (_wordString.Contains("?"))
                {
                    stringBuilder.Append("?");
                }         
            return stringBuilder.ToString();
        }
        else
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < _wordString.Length; i ++)
            {
                stringBuilder.Append("_");
            }
            return stringBuilder.ToString();
        }
    }
}