/* Written by Daniel Loveless */
using System.Text;

public class Word
{
    private string _text;
    private int _length;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _length = _text.Length;
        _isHidden = false;
    }

    public Word(string text, bool isHidden)
    {
        _text = text;
        _length = _text.Length;
        _isHidden = isHidden;
    }

    public bool GetIsHidden()
    {
        return _isHidden;
    }

    public int GetLength()
    {
        return _length;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Display()
    {
        if (_isHidden)
        {
            string hiddenWord = new string('_', _length);
            Console.Write(hiddenWord);
        }
        else
        {
            Console.Write($" {_text}");
        }
    }
}
