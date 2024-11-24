using System.Text;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] wordsArray = text.Split(' ');

        foreach (var word in wordsArray)
        {
            _words.Add(new Word(word));
        }
    }

public void HideRandomWords(int numberToHide)
{
    List<int> indices = new List<int>();
    for (int i = 0; i < _words.Count; i++)
    {
        indices.Add(i);
    }

    Random random = new Random();

    int contador = 0;
    while (contador < numberToHide)
    {
        if (indices.Count == 0)
        {
            break;
        }
        else
        {
            int randomIndex = random.Next(indices.Count);
            int wordIndex = indices[randomIndex];
            
            if (!_words[wordIndex].IsHidden())
            {
                _words[wordIndex].Hide();
                indices.RemoveAt(randomIndex);
                contador += 1;
            }
            else
            {
                continue;
            }
        }
    }
}

    public string GetDisplayText()
    {
        StringBuilder displayText = new StringBuilder();

        foreach (Word word in _words)
        {
            displayText.Append(word.GetDisplayText() + " ");
        }

        return displayText.ToString().Trim();
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}