class Word {

    private string _letters;

    private bool _isHidden;

    public Word (string letters) {
        _letters = letters;
        _isHidden = false;
    }

    public bool GetHidden(){
        return _isHidden;
    }


    public void Hide() {
        _isHidden = true;

    }

    public void Unhide() {
        _isHidden = false;
    }

    public string GetText() {
        if (_isHidden) {
            
            string underscores = " ";
            int numLetters = _letters.Length;
            for (int i = 0; i<numLetters; i++) {
                underscores += "_";
            }
            return underscores;
        }
        else {
            return _letters;
        }
    }
}
class Scripture {
    private List<Word> _words = new List<Word>();

    public Scripture(string text){
        string[] words = text.Split(" ");
        foreach (var w in words){
            var word = new Word(w);
            _words.Add(word);
        }
    }

    public void Display(){
        foreach(var w in _words){
            Console.Write(w.GetText());
            Console.Write(" ");

        }
    }

    public bool IsallHidden(){
        foreach(var w in _words){
            if (w.GetHidden()==false){
                return false;
            }
        }
        return true;
    }


    public Word[] PickRandom(){
        Random rnd = new Random();
         int remainingWordsCount = _words.Count(w => !w.GetHidden());
         int wordsToPick = Math.Min(3, remainingWordsCount);
         Word[] RandomWords = new Word[wordsToPick];
         List<int> selectedIndices = new List<int>();

        for (int i = 0; i < wordsToPick; i++)
           {
        int index;
        do
        {
            index = rnd.Next(_words.Count);
        } while (selectedIndices.Contains(index)|| _words[index].GetHidden());

        RandomWords[i] = _words[index];
        selectedIndices.Add(index);
        RandomWords[i].Hide();
    }

    return RandomWords;
}
            
            
}


class Reference {
    public string _chapter;

    public string _verse;

    public string _reference;

    public Reference (string chapter, string verse, string reference){
        _chapter = chapter;
        _verse = verse;
        _reference = reference;
        
    }

}
